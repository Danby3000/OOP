using System.Collections;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guesses = 0;
            WordCheck wc = new WordCheck();

            Console.WriteLine("Welcome, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Well {0}, this is the hangmans office and you're a fixin for todays hangin'", name);
            Console.WriteLine("Below I will display an empty word and you have to guess what it is letter by letter. You have 7 goes\n");

            //generate word and placeholder

            string word = "banana";
            char[] placeholder = "------".ToCharArray();

            

            do
            {
                Console.WriteLine(new string(placeholder)+ "\n");
                Console.WriteLine("What is your guess?");
                String guessIn = Console.ReadLine();

                while (String.IsNullOrWhiteSpace(guessIn))
                {
                    Console.WriteLine("Input is null or empty...");
                    guessIn = Console.ReadLine();
                }
                while (guessIn.All(char.IsDigit))
                {
                    Console.WriteLine("That is a number...");
                    guessIn = Console.ReadLine();
                }
                while (guessIn.Length > 1)
                {
                    Console.WriteLine("Only ONE letter please...");
                    guessIn = Console.ReadLine();
                }

                char guess = (guessIn.ToLower()).ToCharArray()[0];

                if (wc.InWord(word, guess))
                {
                    ArrayList arr = wc.CharPositions(word, guess);
                    foreach(int i in arr)
                    {
                        placeholder[i] = guess;
                    }
                }





            } while (guesses < 7);
        }
    }
}