using System;
using System.Text;

namespace ReverseString
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(Reverced(text));
        }

        static string Reverced(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }
    }
}
