using System;
using System.Linq;

namespace RandomizeWord
{
    class RandomizeWord
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var firstWord = rnd.Next(0, words.Length);
                var secondWord = rnd.Next(0, words.Length);

                var temp = words[firstWord];
                words[firstWord] = words[secondWord];
                words[secondWord] = temp;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
