using System;

namespace ReverseAnArrayOfIntegers
{
    class ReverseAnArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var numberArray = new int[number];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i= numberArray.Length-1;  i>= 0; i--)
            {
                Console.WriteLine(numberArray[i]);
            }
        }
    }
}
