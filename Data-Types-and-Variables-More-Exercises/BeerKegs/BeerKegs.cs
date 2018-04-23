using System;

namespace BeerKegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            byte countKegs = byte.Parse(Console.ReadLine());
            string biggestKegModel = "";
            double biggestKegVolume = 0;

            for (int i = 1; i <= countKegs; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double kegVolume = (double)Math.PI * radius * radius * height;

                if (kegVolume > biggestKegVolume)
                {
                    biggestKegVolume = kegVolume;
                    biggestKegModel = model;
                }
            }
           
            Console.WriteLine(biggestKegModel);
        }
    }
}
