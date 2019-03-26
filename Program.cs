using System;
using SingleResposabilityPrinciple;

namespace DesignPatterns_SRP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            var user = PersonDataCapture.Capture();

            //Check to be sure that first and last names are valid
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name !");
                StandardMessages.EndApplication();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You did not give us a valid last name !");
                StandardMessages.EndApplication();
                return;
            }

            // Create username for the person
            Console.WriteLine($"Your username is {user.FirstName}{user.LastName}");
            StandardMessages.EndApplication();
        }
    }
}