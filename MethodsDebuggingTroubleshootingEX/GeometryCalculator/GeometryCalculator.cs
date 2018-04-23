using System;

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double area = 0;

            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = TriangleArea(side, height);
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = SquareArea(side);
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = RectangleArea(width, height);
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = CircleArea(radius);
            }

            Console.WriteLine($"{area:f2}");
        }

        private static double CircleArea(double radius)
        {
            double circleArea = Math.PI * Math.Pow(radius, 2);
            return circleArea;
        }

        private static double RectangleArea(double width, double height)
        {
            double rectangleArea = width * height;
            return rectangleArea;
        }

        private static double SquareArea(double side)
        {
            double sqaureArea = side * side;
            return sqaureArea;
        }

        private static double TriangleArea(double side, double height)
        {             
            double triangleArea = (side * height) / 2;
            return triangleArea;
        }
    }
}
