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
                StandardMessages.DisplayValidatorError("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidatorError("last name");
                return false;
            }

            return true;
        }
    }
}