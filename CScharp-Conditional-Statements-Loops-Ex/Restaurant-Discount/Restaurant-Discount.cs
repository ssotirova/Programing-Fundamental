using System;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = string.Empty;
            decimal priceHall = 0;

            if (groupSize<=50)
            {
                hall = "Small Hall";
                priceHall = 2500;
            }
            else if (50 < groupSize && groupSize <=100)
            {
                hall = "Terrace";
                priceHall = 5000;
            }
            else if (100 < groupSize && groupSize <= 120)
            {
                hall = "Great Hall";
                priceHall = 7500;
            }
            else if(groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            decimal discount = 0;
            decimal discountPrice = 0;

            switch (package)
            {
                case "Normal": discount = 0.05m;
                    discountPrice = 500;
                    break;
                case "Gold": discount = 0.1m;
                    discountPrice = 750;
                    break;
                case "Platinum": discount = 0.15m;
                    discountPrice = 1000;
                    break;
                default:
                    break;
            }

            decimal totalPrice = priceHall + discountPrice;
            discount = totalPrice - (totalPrice * discount);
            decimal pricePerPerson = discount / groupSize;

            Console.WriteLine($"We can offer you the {hall} \r\nThe price per person is {pricePerPerson:f2}$");
        }
    }
}
