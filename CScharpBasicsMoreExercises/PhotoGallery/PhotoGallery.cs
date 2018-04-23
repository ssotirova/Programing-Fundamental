using System;

namespace PhotoGallery
{
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            int countPhoto = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photoSize = double.Parse(Console.ReadLine());
            int widthPhoto = int.Parse(Console.ReadLine());
            int heightPhoto = int.Parse(Console.ReadLine());

            string orientation = "";

            Console.WriteLine($"DSC_{countPhoto:d4}.jpg");
            Console.WriteLine($"Date Taken: {day}/{month}/{year} {hours}:{minutes:d2}");

            if (photoSize < 1000)
            {
                Console.WriteLine($"Size: {photoSize}B");
            }
            else if (photoSize >= 1000 && photoSize < 1000000)
            {
                photoSize /= 1000;
                Console.WriteLine($"Size: {photoSize}KB");
            }
            else
            {
                photoSize /= 1000000;
                Console.WriteLine($"Size: {photoSize}MB");
            }

            if (widthPhoto > heightPhoto)
            {
                orientation = "landscape";
            }
            else if (widthPhoto < heightPhoto)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }

            Console.WriteLine($"Resolution: {widthPhoto}x{heightPhoto} ({orientation})");
        }
    }
}
