using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ {1}[A-Z][a-z]+\b";

            MatchCollection result = Regex.Matches(input, pattern);

            foreach (Match item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
