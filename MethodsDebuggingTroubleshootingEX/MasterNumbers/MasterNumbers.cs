using System;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 0; number <= n; number++)
            {
                if (IsPalindrome(number.ToString()) && (SumOfDigits(number) % 7 == 0) && IsContainsEvenDigit(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        private static long SumOfDigits(long n)
        {
            long sumOfDigits = 0;
            while (n > 0)
            {
                long digit = n % 10;
                sumOfDigits += digit;
                n /= 10;
            }
            return sumOfDigits;
        }

        private static bool IsContainsEvenDigit(int num)
        {
            bool cantainEvenDigit = false;
            while (num > 0)
            {
                int curruntDigit = num % 10;
                if (curruntDigit % 2 == 0)
                {
                    cantainEvenDigit = true;
                    break;
                }
                else
                {
                    num /= 10;
                }
            }
            return cantainEvenDigit;
        }

        private static bool IsPalindrome(string n)
        {
            for (int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] != n[n.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
