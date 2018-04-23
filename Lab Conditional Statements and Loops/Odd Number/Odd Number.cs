using System;

namespace Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 0; i < 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number%2==0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine("The number is: {0}", Math.Abs(number));
                    break;
                }
            }
        }
    }
}
