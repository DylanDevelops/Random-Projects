// create a system that censors curse words with asterisks (*)
// the system should be able to censor any curse word in a sentence

using System;

namespace Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence to censor: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Enter a word to censor: ");
            string word = Console.ReadLine();
            string censored = Censor(sentence, word);
            Console.WriteLine(censored);
        }

        static string Censor(string sentence, string word)
        {
            string[] words = sentence.Split(" ");
            string censored = "";
            foreach (string w in words)
            {
                if (w == word)
                {
                    censored += new string('*', word.Length) + " ";
                }
                else
                {
                    censored += w + " ";
                }
            }
            return censored;
        }
    }
}