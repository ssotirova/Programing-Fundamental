using System;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            if (IsPrimeNumber(number))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static bool IsPrimeNumber(long number)
        {
            long sqrtN = (long)Math.Sqrt(number);
            if (number <= 1)
            {
                return false;
            }
            else if (number > 2)
            {
                for (int cnt = 2; cnt <= sqrtN; cnt++)
                {
                    if (number % cnt == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
    
}
