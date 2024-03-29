﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {
        // Member Variables
        public Dictionary<int, Contestant> contestants;
        public Random rand;
        
        // Constructor
        public Sweepstakes(string name)
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
            UserInterface.DisplayWinner(contestant);
        }
    }
}
