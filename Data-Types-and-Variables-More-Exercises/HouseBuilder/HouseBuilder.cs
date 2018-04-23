using System;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long sPrice = long.Parse(Console.ReadLine());
            long iPrice = long.Parse(Console.ReadLine());

            if (sPrice <= 127)
            {
                sPrice *= 4;
                iPrice *= 10;
            }
            else
            {
                sPrice *= 10;
                iPrice *= 4;
            }
            long totalPrice = sPrice + iPrice;

            Console.WriteLine(totalPrice);
        }
    }
}
