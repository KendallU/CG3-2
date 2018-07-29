using System;

namespace Win_Lose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number: 1-10");
            string userValue = Console.ReadLine();

            if (userValue == "8")
            {
                string message = "You Win!";
                Console.WriteLine(message);
            }
            else 
            {
                string message = "You Lose!";
                Console.WriteLine(message);
            }
            Console.ReadLine();
        }
    }
}
