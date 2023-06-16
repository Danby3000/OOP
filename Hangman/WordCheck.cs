using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class WordCheck
    {
        public bool InWord(string word, char letter)
        {
            return word.Contains(letter);
        }

        public ArrayList CharPositions(string word, char letter) 
        {
            bool allFound = false;
            ArrayList indexes = new ArrayList();

            int firstDex = word.IndexOf(letter);
            int lastDex = word.LastIndexOf(letter);

            while (!allFound)
            {
                if (firstDex == lastDex)
                {
                    indexes.Add(firstDex);
                    allFound = true;
                } else
                {
                    indexes.Add(firstDex);
                    int startpos = firstDex + 1;
                    firstDex = word.IndexOf(letter, startpos);
                }
            }
            return indexes;
        }

        public bool IsComplete(string word)
        {
            return (!word.Contains('_'));
        }


    }
}
