using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        // Member Variables
        public ISweepstakesManager sweepstakes;
        public Queue<Sweepstakes> queue;

        // Constructor
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        // Member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = queue.Dequeue();
            return sweepstakes;
        }
    }
}
