using System;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Guessing number game.

            var r = new Random();
            var favNumber = r.Next(0, 1000);
            int userInput;
            var counter = 0;

            do
            {

                Console.WriteLine("Hello, Pick a number from 1 - 1000.");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high.");
                }
                else
                {
                    Console.WriteLine("You Guessed it!");
                }

                counter++;
                Console.WriteLine($"You Have Guessed {counter} times.");

            }while (userInput != favNumber);
        }
    }
}
