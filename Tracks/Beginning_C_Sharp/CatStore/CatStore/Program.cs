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

        static void Main(string[] args)
        {
            // Display a welcome message for the sotre
            Console.WriteLine("Welcome to the cat food store!");

            // Wait timer before the question is asked
            Wait(1000);

            // Ask method to get the amount for order from the user
            string entry = Ask("How many cans are you ordering?");
            Console.WriteLine("You entered " + entry + " cans"); // Contat the entry for the user
            
            
            
        }
    }
}
