using System;

namespace EnglishNameOfTheLastDigit
{
    class EnglishNameOfTheLastDigit
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string numberName = LastDigit(number);
            
            Console.WriteLine(numberName);
        }

        static string LastDigit(long number)
        {
            number = Math.Abs(number);
            long lastDigit = number % 10;
            string numberName = "";

            switch (lastDigit)
            {
                case 0:
                    numberName = "zero";
                    break;
                case 1:
                    numberName = "one";
                    break;
                case 2:
                    numberName = "two";
                    break;
                case 3:
                    numberName = "three";
                    break;
                case 4:
                    numberName = "four";
                    break;
                case 5:
                    numberName = "five";
                    break;
                case 6:
                    numberName = "six";
                    break;
                case 7:
                    numberName = "seven";
                    break;
                case 8:
                    numberName = "eight";
                    break;
                case 9:
                    numberName = "nine";
                    break;
                default:
                    break;
            }

            return numberName;
            
        }

    }
}
