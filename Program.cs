using System;
using System.Linq.Expressions;

namespace Program {

    public abstract class Candidate
    {
        public abstract string GetName();
        public abstract string GetParty();
        public abstract int GetVotes();
        public abstract void SetVote();
    }

    public class CandidateA : Candidate
    {
        private string _name;
        private string _party;
        private static int _vote = 0;

        public CandidateA(string name, string party)
        {
            _name = name;
            _party = party;
        }

        public override string GetName() => _name;
        public override string GetParty() => _party;
        public override int GetVotes() => _vote;
        public override void SetVote() { _vote++; }

    }

    public class CandidateB : Candidate
    {
        private string _name;
        private string _party;
        private static int _vote = 0;

        public CandidateB(string name, string party)
        {
            _name = name;
            _party = party;
        }

        public override string GetName() => _name;
        public override string GetParty() => _party;
        public override int GetVotes() => _vote;
        public override void SetVote() { _vote++; }

    }

    public class CandidateC : Candidate
    {
        private string _name;
        private string _party;
        private static int _vote = 0;

        public CandidateC(string name, string party)
        {
            _name = name;
            _party = party;
        }

        public override string GetName() => _name;
        public override string GetParty() => _party;
        public override int GetVotes() => _vote;
        public override void SetVote() { _vote++; }

    }

    public class VotingMachine
    {
        public void VoteForCandidate(Candidate selectedCandidate) => selectedCandidate.SetVote();
    }


    public class Program
    {
        static void Main(string[] args)
        {
            VotingMachine machine = new VotingMachine();
            CandidateA candidateA = new CandidateA("Oldri", "Green");
            CandidateB candidateB = new CandidateB("Loris", "Liberal");
            CandidateC candidateC = new CandidateC("Arjola Ridvan", "Conservative");
            bool setEndVoting = false;

            while (!setEndVoting)
            {
                Console.WriteLine("Pick a candidate: \n" +
               "Enter 1 for Candidate A: " + candidateA.GetName() + ", " + candidateA.GetParty() + "\n" +
               "Enter 2 for Candidate B: " + candidateB.GetName() + ", " + candidateB.GetParty() + "\n" +
               "Enter 3 for Candidate C: " + candidateC.GetName() + ", " + candidateC.GetParty() + "\n" +
               "Type 'end' to stop voting.");

                string selectedCandidate = Console.ReadLine();
                if (selectedCandidate.ToLower() != "end")
                {
                    switch (selectedCandidate)
                    {
                        case "1":
                            machine.VoteForCandidate(candidateA);
                            break;
                        case "2":
                            machine.VoteForCandidate(candidateB);
                            break;
                        case "3":
                            machine.VoteForCandidate(candidateC);
                            break;
                        default:
                            Console.WriteLine("No option selected.");
                            break;
                    }
                }
                else setEndVoting = true;
            }
            
            Console.WriteLine($"Candidates Votes: \n" +
                $"Name: {candidateA.GetName()}, Party: {candidateA.GetParty()}, Votes: {candidateA.GetVotes()} \n" +
                $"Name: {candidateB.GetName()}, Party: {candidateB.GetParty()}, Votes: {candidateB.GetVotes()} \n" +
                $"Name: {candidateC.GetName()}, Party: {candidateC.GetParty()}, Votes: {candidateC.GetVotes()}");

        }
    }

}