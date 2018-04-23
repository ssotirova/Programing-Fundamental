using System;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            try
            {
                short.Parse(number);
                Console.WriteLine("Sunny");
            }
            catch 
            {
                try
                {
                    int.Parse(number);
                    Console.WriteLine("Cloudy");
                }
                catch 
                {

                    try
                    {
                        long.Parse(number);
                        Console.WriteLine("Windy");
                    }
                    catch
                    {
                        try
                        {
                            float.Parse(number);
                            Console.WriteLine("Rainy");
                        }
                        catch
                        {

                        }
                    }
                }
               
            }
        }
    }
}
