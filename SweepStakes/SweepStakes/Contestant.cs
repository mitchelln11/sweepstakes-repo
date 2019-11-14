using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant : IObserverPatternWinner
    {
        // Member variables
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        // Constructor
        public Contestant(string name)
        {
            firstName = UserInterface.GetFirstName();
            lastName = UserInterface.GetLastName();
            emailAddress = UserInterface.GetEmail();
            registrationNumber = UserInterface.GetRegistration();
            this.name = name;
        }

        // Member methods
        public void DisplayContestantInfo()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(emailAddress);
            Console.WriteLine(registrationNumber);
        }

        public void Notify(IObserverPatternWinner observerPatternWinner)
        {
            if (Contestant contestant == true) // How to actually separate conditional messages
            {
                Console.Write("Congratulations {0} {1}, you are the winner!", firstName + lastName);
                UserInterface.DisplayWinner(contestant);
            }
            if else (Contestant contestant == false)
            {
            Console.WriteLine("I'm sorry, you are not the winner of the sweepstakes.");
            }
        }
    }
}
