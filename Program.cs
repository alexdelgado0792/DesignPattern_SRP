using SingleResposabilityPrinciple;
using SingleResposabilityPrinciple.Validators;
using SingleResposabilityPrinciple.BusinessLogic;

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
                return;
            }

            AccountGenerator.CreateAccount(user);
            
            StandardMessages.EndApplication();
        }
    }
}