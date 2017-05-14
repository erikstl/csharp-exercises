using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "this", "is", "a", "list", "of", "words", "that", "might", "be", "long!" };
            CountWords(words);
            Console.ReadLine();
        }

        public static void CountWords(List<string> words)
        {
            List<string> fiveLetterWords = new List<string>();
            for (int i = 0; i<words.Count; i++)
            {
                if (words[i].Length == 5)
                {
                    fiveLetterWords.Add(words[i]);
                }
            }
            foreach (string word in fiveLetterWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
