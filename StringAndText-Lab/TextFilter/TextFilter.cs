using System;
using System.Linq;

namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var ban in bannedWords)
            {
                if (text.Contains(ban))
                {
                    text = text.Replace(ban, new string('*', ban.Length));
                }
            }
            
            Console.WriteLine(text);
        }
    }
}
