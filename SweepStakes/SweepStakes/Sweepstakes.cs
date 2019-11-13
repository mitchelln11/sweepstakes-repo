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
        
        // Constructor
        public Sweepstakes()
        {
            contestants = new Dictionary<int, Contestant>();
        }

        // Member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }

        //public Contestant PickWinner()
        //{
        //    // Code here
        //}

        public void PrintContestantInfo()
        {
            // Code here
        }
    }
}
