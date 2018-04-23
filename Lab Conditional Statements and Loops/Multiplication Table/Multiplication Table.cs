using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int product = 0;
            for (int i = 1; i <=10; i++)
            {
                product = theInteger * i;
                Console.WriteLine($"{theInteger} X {i} = {product}");
            }
        }
    }
}
