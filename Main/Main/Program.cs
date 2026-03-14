using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Statistics App!");
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();

            if (!StatisticsHelper.IsValidInput(input)) {
                Console.WriteLine("Error: Input cannot be empty!");
                return;
            }

            Console.WriteLine($"You entered: {input}");
        }
    }
}