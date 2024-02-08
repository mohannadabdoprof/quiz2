using System;
using System.Collections.Generic;

namespace app2demoissue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            
            List<string> todoItems = new List<string>
            {
                "quiz#2",
                "Update project documentation",
                "Review pull requests"
            };

            Console.WriteLine("Todo Items:");
            foreach (var item in todoItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
