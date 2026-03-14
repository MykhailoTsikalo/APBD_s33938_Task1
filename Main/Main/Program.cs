//This is the main starting point of the application
using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the AWESOME Statistics App!");
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();

            if (!StatisticsHelper.IsValidInput(input)) {
                Console.WriteLine("Error: Input cannot be empty!");
                return;
            }

            Console.WriteLine($"You entered: {input}");

            Console.WriteLine("Goodbye");
        }
    }
}