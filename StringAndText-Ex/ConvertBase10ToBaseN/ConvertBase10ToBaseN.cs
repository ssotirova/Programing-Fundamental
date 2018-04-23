using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConvertBase10ToBaseN
{
    class ConvertBase10ToBaseN
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int baseNumber = numbers[0];
            int convertedNumber = numbers[1];
            BigInteger buffer = new BigInteger();
            string result = null;

            if (baseNumber >= 2 && baseNumber <= 10)
            {
                while (convertedNumber > 0)
                {
                    buffer = convertedNumber % baseNumber;
                    convertedNumber /= baseNumber;

                    result = buffer.ToString() + result;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
                        
        }
    }
}
