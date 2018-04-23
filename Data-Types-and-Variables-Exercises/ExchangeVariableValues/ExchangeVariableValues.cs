using System;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int firstVariable = int.Parse(Console.ReadLine());
            int secondvariable = int.Parse(Console.ReadLine());
            Console.WriteLine("Before: ");
            Console.WriteLine($"a = {firstVariable}");
            Console.WriteLine($"b = {secondvariable}");

            int buffer = firstVariable;
            firstVariable = secondvariable;
            secondvariable = buffer;

            Console.WriteLine("After: ");
            Console.WriteLine($"a = {firstVariable}");
            Console.WriteLine($"b = {secondvariable}");
        }
    }
}
