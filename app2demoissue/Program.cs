using System;
using System.Collections.Generic;

namespace app2demoissue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> todoItems = new List<string>
            {
                "Complete assignment",
                "Read chapter 4"
            };

            Console.WriteLine("Initial Todo Items:");
            foreach (var item in todoItems)
            {
                Console.WriteLine(item);
            }

            todoItems.Add("quiz#2");

            Console.WriteLine("\nUpdated Todo Items:");
            foreach (var item in todoItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
