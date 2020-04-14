using System;
using System.Threading;
namespace CatStore
{
    
    class Program
    {
        static string Ask(string question)
        {
            Console.Write(question + " "); // Concat a space
            return Console.ReadLine();            
        }

        static void Wait(int delay)
        {
            Console.Write(".");
            Thread.Sleep(delay);
            Console.Write(".");
            Thread.Sleep(delay);
            Console.Write(".");
            Console.WriteLine("");
            Thread.Sleep(delay);            
        }

        static double Price(int quantity)
        {
            double pricePerUnit;
            if (quantity >= 100)
            {
               pricePerUnit = 1.5;
            }
            else if (quantity >= 50)
            {
               pricePerUnit = 1.75;
            }
            else 
            {
                pricePerUnit = 2;
            }
            return quantity * pricePerUnit;
            
        }

        static void Main(string[] args)
        {
            // Display a welcome message for the sotre
            Console.WriteLine("Welcome to the cat food store!");

            // Wait timer before the question is asked
            Wait(1000);

            // Ask method to get the amount for order from the user
            string entry = Ask("How many cans are you ordering?");
            // Console.WriteLine("You entered " + entry + " cans");  Contat the entry for the user
            //Console.WriteLine($"You entered {entry} cans"); // Interpolation
            int number = int.Parse(entry); // Convert sting to number with parse
            double total = Price(number);
            Console.WriteLine($"For {number} cans, your total is: ${total}");
            
            
            
        }
    }
}
