using System;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int newNumber = Convert.ToInt32(number, 16);

            Console.WriteLine(newNumber);
        }
    }
}
