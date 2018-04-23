using System;
using System.Collections.Generic;


namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            List<int> primeList = FindPrimesInRange(startNumber,endNumber);
            string numbers = String.Join(", ", primeList);
            Console.WriteLine(numbers);
        }

        static List<int> FindPrimesInRange(int start, int end)
        {
            var result = new List<int>();

            if (start == 0 || start == 1)
            {
                start = 2;
            }
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                                
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
