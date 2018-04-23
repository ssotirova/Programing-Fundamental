using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            short countChars = short.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < countChars; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int number = Convert.ToInt32(letter);
                sum += number;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
