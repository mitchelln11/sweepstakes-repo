using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class UserInterface
    {
        // Member Variables
        public static int registrationNumber;

        // Constructor

        // Member methods
        public static string GetFirstName()
        {
            Console.WriteLine("Please type in your first name.");
            string firstName = Console.ReadLine().Replace(" ", "").Trim();
            return firstName;
        }

        public static string GetLastName()
        {
            Console.WriteLine("Please type in your last name.");
            string lastName = Console.ReadLine().Replace(" ", "").Trim();
            return lastName;
        }

        public static string Getemail()
        {
            Console.WriteLine("Please type in your email.");
            string emailAddress = Console.ReadLine().Replace(" ", "").Trim();
            return emailAddress;
        }

        public static int GetRegistration()
        {
            registrationNumber += 1;
            Console.WriteLine("Registration #: " + registrationNumber);
            Console.ReadLine();
            return registrationNumber;
        }
    }
}
