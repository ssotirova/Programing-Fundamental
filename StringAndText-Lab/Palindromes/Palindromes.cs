using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new string[] { " ", ",", ";", "?", "!", ":", "." }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palidromes = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                string word = text[i];

                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == word[word.Length-1-j])
                    {
                        palidromes.Add(word);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }                
            }

            var sorted = palidromes.OrderBy(x => x).Distinct().ToList();
            Console.WriteLine(string.Join(", ", sorted));
        }
    }
}
