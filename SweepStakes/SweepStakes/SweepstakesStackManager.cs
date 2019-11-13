using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        // Member Variables
        public ISweepstakesManager sweepstakes;
        public Stack<Sweepstakes> stack; 

        // Constructor
        public SweepstakesStackManager(Sweepstakes sweepstakes)
        {
            stack = new Stack<Sweepstakes>();
            //this.sweepstakes = sweepstakes;
        }

        // Member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = stack.Pop();
            return sweepstakes;
        }

        public void Stack(ISweepstakesManager sweepstakes)
        {
            this.sweepstakes = sweepstakes;
        }
    }
}
