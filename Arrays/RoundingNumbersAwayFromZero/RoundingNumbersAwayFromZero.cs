using System;
using System.Linq;

namespace RoundingNumbersAwayFromZero
{
    class RoundingNumbersAwayFromZero
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var roundedNumbers = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                roundedNumbers[i] = (int) Math.Round(array[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} => {roundedNumbers[i]}");
            }
        }
    }
}
