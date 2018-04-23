using System;

namespace BoatSimulator
{
    class BoatSimulator
    {
        static void Main(string[] args)
        {
            char signFirstBoat = char.Parse(Console.ReadLine());
            char signSecondBoad = char.Parse(Console.ReadLine());
            int countLines = int.Parse(Console.ReadLine());
            int sumFirstBoadMoves = 0;
            int sumSecondBoadMoves = 0;
            int convertedSignFirst = Convert.ToInt32(signFirstBoat);
            int convertedSignSecond = Convert.ToInt32(signSecondBoad);

            for (int i = 1; i <= countLines; i++)
            {
                string lines = Console.ReadLine();
                
                if (i % 2 == 0)
                {
                    sumSecondBoadMoves += lines.Length;
                                       
                }
                else if (i % 2 != 0)
                {
                    sumFirstBoadMoves += lines.Length;
                                       
                }
                if (lines == "UPGRADE")
                {
                    convertedSignSecond += 3;
                    convertedSignFirst += 3;
                }
                if (sumFirstBoadMoves >= 50 || sumSecondBoadMoves >=50)
                {
                    break;
                }

            }

            char lastSecond = Convert.ToChar(convertedSignSecond);
            char lastFirst = Convert.ToChar(convertedSignFirst);

            if (sumFirstBoadMoves > sumSecondBoadMoves)
            {
                Console.WriteLine(lastFirst);
            }
            else if (sumSecondBoadMoves > sumFirstBoadMoves)
            {
                Console.WriteLine(lastSecond);
            }
            else if (sumSecondBoadMoves == 50)
            {                
                Console.WriteLine(lastSecond);
            }
            else if (sumFirstBoadMoves == 50)
            {                
                Console.WriteLine(lastFirst);
            }
        }
    }
}
