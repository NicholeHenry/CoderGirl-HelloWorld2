using System;

namespace HelloWorld2
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Please enter your name: ");

            string userName = Console.ReadLine();

            // Store a name the user enters to a variable.

            // Output - Hello (name)!
            Console.WriteLine($"Hello{userName}!");
            Console.ReadLine();
        }
    }
}
