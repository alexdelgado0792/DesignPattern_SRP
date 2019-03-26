using System;

namespace SingleResposabilityPrinciple
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my Application !!!");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DisplayValidatorError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid { fieldName }!");
        }
    }
}