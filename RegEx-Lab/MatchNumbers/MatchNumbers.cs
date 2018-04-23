using System;
using System.Text.RegularExpressions;

namespace MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?(\d+)(\.\d+)?($|(?=\s))";

            var match = Regex.Matches(input, pattern);
            foreach (Match item in match)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
