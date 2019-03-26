using System;
using DesignPatterns_SRP;

namespace SingleResposabilityPrinciple.Validators
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            //Check to be sure that first and last names are valid
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name !");
                StandardMessages.EndApplication();
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                Console.WriteLine("You did not give us a valid last name !");
                StandardMessages.EndApplication();
                return false;
            }

            return true;
        }
    }
}