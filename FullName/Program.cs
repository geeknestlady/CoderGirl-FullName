using System;

namespace FullName
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            string fullName = FullName(firstName, lastName);
            Console.WriteLine(fullName);
            // TODO: Ask the user for their first name and then their last name.

            // TODO: Call a method called FullName that returns their full name.

            // TODO: Output their full name.

            Console.ReadLine();
        }
        public static string FullName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;

        }

    
        // TODO: Create a method call FullName that takes the firstName and lastName as parameters.
    }
}
