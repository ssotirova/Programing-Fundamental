using System;
using System.Text.RegularExpressions;

namespace ReplaceATag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            while (true)
            {
                if (inputLine == "end")
                {
                    break;
                }
                else
                {
                    string result = Regex.Replace(inputLine, @"<a.*?href.*?=(.*?)>(.*?)<\/a>", @"[URL href=$1]$2[/URL]");
                    Console.WriteLine(result);
                    inputLine = Console.ReadLine();
                }
            }
        }
    }
}
