using System;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float allTimeInseconds = seconds + (minutes * 60) + (hours * 60 * 60);
            float speedMetersPerSeconds = distanceInMeters / allTimeInseconds;

            float allTimeInHours = allTimeInseconds / 3600;
            float metersInkilometers = distanceInMeters / 1000;
            float speedKmPerHours = metersInkilometers / allTimeInHours;

            float metersInMiles = distanceInMeters / 1609;
            float speedMilesPerHours = metersInMiles / allTimeInHours;

            Console.WriteLine($"{speedMetersPerSeconds:0.######}");
            Console.WriteLine($"{speedKmPerHours:0.######}");
            Console.WriteLine($"{speedMilesPerHours:0.######}");
        }
    }
}
