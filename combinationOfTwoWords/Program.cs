using System;

namespace combinationOfTwoWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1, word2, wordCombination;
            
            Console.WriteLine("First word: ");
            word1 = Console.ReadLine();

            Console.WriteLine("Second Word: ");
            word2 = Console.ReadLine();

            wordCombination = word1 + word2;
            Console.WriteLine(wordCombination);
        }
    }
}
