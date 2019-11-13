using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm
    {
        // Member Variables
        public ISweepstakesManager manager;
        public string managerChoice; // Declare variable that's going to be used on the UserInterface.
        public string sweepName;

        // Constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager; // dependancy injection
            managerChoice = UserInterface.GetManagerOption(); // Grab GetManagerOption from UserInterface
            sweepName = UserInterface.GetSweepstakeName();
        }

        public void GetSweepName()
        {
            string sweepstakesName = UserInterface.GetSweepstakeName();
            Sweepstakes newSweepstake = new Sweepstakes(sweepstakesName);
        }
    }
}
