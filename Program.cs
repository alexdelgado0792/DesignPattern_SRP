using System;
using SingleResposabilityPrinciple;
using SingleResposabilityPrinciple.Validators;

namespace DesignPatterns_SRP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            var user = PersonDataCapture.Capture();

            // same as PersonValidator.Validate(user) == false
            if (!PersonValidator.Validate(user))
            {
                StandardMessages.EndApplication();
            }

            // Create username for the person
            Console.WriteLine($"Your username is {user.FirstName}{user.LastName}");
            StandardMessages.EndApplication();
        }
    }
}