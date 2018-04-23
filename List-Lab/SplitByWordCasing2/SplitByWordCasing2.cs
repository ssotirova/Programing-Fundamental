using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> lower = new List<string>();
            List<string> upper = new List<string>();
            List<string> mixed = new List<string>();

            foreach (var word in words)
            {
                if (word[0] >= 'a' && word[0] <= 'z')
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        if (word[1] > 'a' && word[1] < 'z')
                        {
                            lower.Add(word);
                        }
                        else
                        {
                            mixed.Add(word);
                        }
                        break;
                    }
                }
                else if (word[0] >= 'A' && word[0] <= 'Z')
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        if (word[1] > 'A' && word[1] < 'Z')
                        {
                            upper.Add(word);
                        }
                        else
                        {
                            mixed.Add(word);
                        }
                        break;
                    }
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lower)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixed)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upper)}");
        }
    }
}
