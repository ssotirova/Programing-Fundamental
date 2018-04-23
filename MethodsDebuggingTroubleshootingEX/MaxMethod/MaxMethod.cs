using System;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdnumber = int.Parse(Console.ReadLine());

            int firstMaxNumber = GetMaxNumber(firstNumber, secondNumber);
            int secondMaxNumber = GetMaxNumber(secondNumber, thirdnumber);

            if (firstMaxNumber > secondNumber)
            {
                Console.WriteLine(firstMaxNumber);
            }
            else
            {
                Console.WriteLine(secondMaxNumber);
            }
        }

        static int GetMaxNumber(int first, int second)
        {
            int maxNumber = 0;
            if (first > second)
            {
                maxNumber = first;
            }
            else if (second > first)
            {
                maxNumber = second;
            }
            else
            {
                maxNumber = first;
            }
            return maxNumber;
        }
    }
}
