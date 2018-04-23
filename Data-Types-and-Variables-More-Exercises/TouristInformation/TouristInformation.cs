using System;

namespace TouristInformation
{
    class TouristInformation
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double convertValue = double.Parse(Console.ReadLine());
            string newImperialUnit = "";

            Console.Write($"{convertValue} {imperialUnit} = ");

            switch (imperialUnit)
            {
                case "miles":
                    convertValue *= 1.6;
                    newImperialUnit = "kilometers";
                    break;
                case "inches":
                    convertValue *= 2.54;
                    newImperialUnit = "centimeters";
                    break;
                case "feet":
                    convertValue *= 30;
                    newImperialUnit = "centimeters";
                    break;
                case "yards":
                    convertValue *= 0.91;
                    newImperialUnit = "meters";
                    break;
                case "gallons":
                    convertValue *= 3.8;
                    newImperialUnit = "liters";
                    break;
                default:
                    break;

                    
            }

            Console.WriteLine($"{convertValue:f2} {newImperialUnit}");
        }
    }
}
