using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
        // Member variables
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        // Constructor
        public Contestant()
        {
            firstName = UserInterface.GetFirstName();
            lastName = UserInterface.GetLastName();
            emailAddress = UserInterface.Getemail();
            registrationNumber = UserInterface.GetRegistration();
        }

        // Member methods
        public void DisplayContestantInfo()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(emailAddress);
            Console.WriteLine(registrationNumber);
        }
    }
}
