using System;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int fistNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int trirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{fistNumber:D4} {secondNumber:D4} {trirdNumber:D4} {fourthNumber:D4}");
        }
    }
}
