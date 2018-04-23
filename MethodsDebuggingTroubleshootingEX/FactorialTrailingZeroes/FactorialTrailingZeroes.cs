using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger factorial = GetFactoriel(N);
            BigInteger zeroes = Zeros(factorial);
            Console.WriteLine(zeroes);
        }

        static BigInteger GetFactoriel(int N)
        {
            BigInteger multiplicationN = 1;
            for (int i = 1; i <= N; i++)
            {
                multiplicationN *= i;
            }
            return multiplicationN;
        }

        static int Zeros(BigInteger factorial)
        {
            int zero = 0;
            while (factorial % 10 == 0)
            {
                zero++;
                factorial /= 10;
            }
            return zero;
        }
    }
    
}
