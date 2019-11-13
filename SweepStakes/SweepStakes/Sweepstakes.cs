using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {
        // Member Variables
        Dictionary<int, Contestant> contestants;
        Random rand;
        
        // Constructor
        public Sweepstakes()
        {
            contestants = new Dictionary<int, Contestant>();
            rand = new Random();
        }

        // Member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            int winningRegNumber = rand.Next(1, contestants.Count + 1);
            Contestant contestant = contestants[winningRegNumber];
            return contestant;
        }

        public void PrintContestantInfo(Contestant contestant) // Not needed,just here for testing purposes
        {
            // Code here
            Console.WriteLine(contestant.firstName);
            Console.WriteLine(contestant.lastName);
            Console.WriteLine(contestant.emailAddress);
            Console.WriteLine(contestant.registrationNumber);
        }
    }
}
