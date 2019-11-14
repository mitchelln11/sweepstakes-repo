using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public interface IObserverPatternWinner
    {
        string Name { get; set; }
        void Notify(IObserverPatternWinner observerPatternWinner);
        // What if the likely class isn't inheritingan interface? Inherit anyway? Just use separate, unrelated methods from Interface?
    }
}
