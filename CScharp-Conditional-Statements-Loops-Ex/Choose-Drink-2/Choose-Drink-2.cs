using System;

namespace Choose_Drink_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0;

            if (profession == "Athlete")
            {
                price = 0.7;
            }
            else if (profession == "Businessman" || profession=="Businesswoman")
            {
                price = 1;
            }
            else if (profession == "SoftUni Student")
            {
                price = 1.7;
            }
            else
            {
                price = 1.2;
            }

            double totalPrice = count * price;
            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}
