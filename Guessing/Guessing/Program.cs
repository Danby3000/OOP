﻿namespace Guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guess = 0;
            int guesses = 0;

            Random r = new Random();
            int number = r.Next(1,100);

            do 
            { 
                Console.WriteLine("What is your guess?");
                String guessIn = Console.ReadLine();
                //input sanitisation needed
                if (String.IsNullOrWhiteSpace(guessIn)) {
                    Console.WriteLine("Invalid input");
                }
                guess = int.Parse(guessIn);
               
                if (guess == number) {
                    Console.WriteLine("You guessed right!");
                    return;
                } else
                {
                    if (guess > number)
                    {
                        Console.WriteLine("Too high");
                    } else
                    {
                        Console.WriteLine("Too low");
                    }
                }
                guesses++; 
            } while (guesses < 6);

            Console.WriteLine("You have run out of guesses :(");

        }
    }
}