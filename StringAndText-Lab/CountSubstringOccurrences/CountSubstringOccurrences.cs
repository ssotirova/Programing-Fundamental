using System;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string find = Console.ReadLine().ToLower();

            int count = 0;
            int index = text.IndexOf(find);
            while (index != -1)
            {
                count++;
                index = text.IndexOf(find, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
