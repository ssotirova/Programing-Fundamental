using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbres = Console.ReadLine();
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";

            var matches = Regex.Matches(phoneNumbres, pattern);
            var matchesPhones = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ",matchesPhones));
        }
    }
}
