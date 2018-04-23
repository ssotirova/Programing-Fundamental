using System;

namespace NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            try
            {
                long.Parse(number);
                Console.WriteLine("integer");
            }
            catch
            {
                try
                {
                    double.Parse(number);
                    Console.WriteLine("floating-point");
                }
                catch
                {

                }              
            }
            
        }
    }
}
