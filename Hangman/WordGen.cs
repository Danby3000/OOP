using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class WordGen
    {
        public List<string> words = new List<string>();
        
        public WordGen() 
        {
            words = new List<string>
            {
                "banana", "naruto", "calculator", "ukulele", "computer", "charmander"
            };
        }

        public string randomWord()
        {
            Random r = new Random();
            int number = r.Next(0, words.Count);
            return words[number];
        }

        public char[] createPlaceholder(string word)
        {
            foreach (char c in word)
            {
                word = word.Replace(c, '_');
            }
            char[] chars = word.ToCharArray();
            return chars;
        }
    }
}
