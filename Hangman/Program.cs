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

            WordGen wg = new WordGen();
            string word = wg.randomWord();
            char[] placeholder = wg.createPlaceholder(word);

            //string word = "banana";
            //char[] placeholder = "------".ToCharArray();

            do
            {
                string placeholderStr = new string(placeholder);
                Console.WriteLine(placeholderStr+ "\n");
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

                        if (wc.IsComplete(word, new string(placeholder)))
                        {
                            Console.WriteLine("It was: {0}", word);
                            Console.WriteLine("Congratulations, you have avoided being hung!!!\n");
                            return;
                        }
                    }
                }
                else
                {
                    guesses++;
                    Console.WriteLine("Wrong, you have used {0} guesses\n", guesses);
                }

            } while (guesses < 7);
        }
    }
}