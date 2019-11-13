using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant contestant = new Contestant();
            contestant.DisplayContestantInfo();

            Console.WriteLine("How would you like to manage your sweepstakes?/n" +
                "Please type Stack or Queue");


            MarketingFirm firm = new MarketingFirm(new SweepstakesQueueManager());
            firm.GetSweepstakeName();
        }
    }
}
