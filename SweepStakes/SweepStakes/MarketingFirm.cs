using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        // Member Variables
        public ISweepstakesManager manager;

        // Constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager; // dependancy injection
        }
        // Member methods
    }
}
