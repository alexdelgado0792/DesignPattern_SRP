using System;

namespace DesignPatterns_SRP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Application !!!");

            //Ask for user information
            Person user = new Person();

            Console.WriteLine("What is your firstName:   ");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is your lastName:   ");
            user.LastName = Console.ReadLine();

            //Check to be sure that first and last names are valid
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name !");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You did not give us a valid last name !");
                Console.ReadLine();
                return;
            }

            // Create username for the person
            Console.WriteLine($"Your username is {user.FirstName}{user.LastName}");
            Console.ReadLine();
        }
    }
}