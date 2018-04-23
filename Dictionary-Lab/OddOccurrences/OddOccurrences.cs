using System;
using System.Collections.Generic;

namespace OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ');
            
            var counts = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
                
            var results = new List<string>();

            foreach (var pair in counts)
            {
                if (pair.Value % 2 == 1)
                {
                    results.Add(pair.Key);
                }
            }
                
          Console.WriteLine(string.Join(", ", results));

        }
    }
}
