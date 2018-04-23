using System;
using System.Linq;

namespace ArrayStasitic
{
    class ArrayStasitic
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double sum = 0.0;
            int max = arr.Max();
            int min = arr.Min();

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                
            }

            double average = sum / arr.Length;
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
