using System;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result = 0;

            if (parameter == "face")
            {
                result = FaceDiagonals(cubSide);
            }
            else if (parameter == "space")
            {
                result = SpaceDiagonals(cubSide);
            }
            else if (parameter == "volume")
            {
                result = CubVolume(cubSide);
            }
            else if (parameter == "area")
            {
                result = SurfaceArea(cubSide);
            }

            Console.WriteLine($"{result:f2}");
        }

        static double FaceDiagonals(double side)
        {
            double lengthFaceDiagonal = Math.Sqrt(2 * Math.Pow(side, 2));
            return lengthFaceDiagonal;
        }

        static double SpaceDiagonals(double side)
        {
            double lengthSpaceDiagonal = Math.Sqrt(3 * Math.Pow(side, 2));
            return lengthSpaceDiagonal;
        }

        static double CubVolume(double side)
        {
            double cubVolume = Math.Pow(side, 3);
            return cubVolume;
        }

        static double SurfaceArea(double side)
        {
            double surfaceArea = 6 * Math.Pow(side, 2);
            return surfaceArea;
        }
    }
}
