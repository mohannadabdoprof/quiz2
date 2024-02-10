using System;

namespace app2demoissue
{
    internal class Program
    {
        #Quiz 2
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Quiz!");

            // Display the question
            Console.WriteLine("What is the capital of France?");
            
            // Display the options
            Console.WriteLine("A) London");
            Console.WriteLine("B) Paris");
            Console.WriteLine("C) Rome");
            Console.WriteLine("D) Berlin");

            // Get user input
            Console.Write("Enter your answer (A, B, C, or D): ");
            string userAnswer = Console.ReadLine();

            // Check the answer
            if (userAnswer.ToUpper() == "B")
            {
                Console.WriteLine("Correct! Paris is the capital of France.");
            }
            else
            {
                Console.WriteLine("Incorrect! The correct answer is B) Paris.");
            }

            // End of quiz
            Console.WriteLine("Thank you for playing the Simple Quiz!");
        }
    }
}
