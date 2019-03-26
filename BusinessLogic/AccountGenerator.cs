using System;
using DesignPatterns_SRP;

namespace SingleResposabilityPrinciple.BusinessLogic
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person person)
        {
            // Create username for the person
            Console.WriteLine($"Your username is {person.FirstName}{person.LastName}");
        }
    }
}