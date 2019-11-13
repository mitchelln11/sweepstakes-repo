using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class FactoryManager
    {
        public static ISweepstakesManager FactoryDecider()
        {
            ISweepstakesManager manager;
            string choice = UserInterface.GetManagerOption();
            if (choice == "stack")
            {
                manager = new SweepstakesStackManager();
                return manager;
            }
            else if (choice == "queue")
            {
                manager = new SweepstakesQueueManager();
                return manager;
            }
            else
            {
                Console.WriteLine("Not a valid option.");
                return FactoryDecider();
            }
        }
        

    }
}
