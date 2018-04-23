using System;

namespace TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int itemsToBuy = int.Parse(Console.ReadLine());
            double sum = 0;
            double totalSum = 0;
            
            for (int i = 1; i <= itemsToBuy; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");

                sum = itemCount * itemPrice;
                totalSum += sum;
            }

            if (budget >= totalSum)
            {
                Console.WriteLine($"Subtotal: ${totalSum:f2}\r\nMoney left: ${Math.Round(budget-totalSum,2)}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${totalSum:f2}\r\nNot enough. We need ${Math.Round(totalSum-budget,2)} more.");
            }
        }
    }
}
