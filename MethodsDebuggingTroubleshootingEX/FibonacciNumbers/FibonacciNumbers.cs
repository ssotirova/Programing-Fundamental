using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int fibNumber = FibonacciNumber(number);
            Console.WriteLine(fibNumber);
        }

        static int FibonacciNumber(int n)
        {
            int first = 1;
            int second = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }
           return second;

        }
    }
}
