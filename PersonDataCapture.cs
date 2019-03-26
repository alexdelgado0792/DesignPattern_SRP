using DesignPatterns_SRP;
using System;

namespace SingleResposabilityPrinciple
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            //Ask for user information
            Person output = new Person();

            Console.WriteLine("What is your firstName:   ");
            output.FirstName = Console.ReadLine();

            Console.WriteLine("What is your lastName:   ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}