using System;

namespace CatchTheThief
{
    class CatchTheThief
    {
        static void Main(string[] args)
        {
            string numerialType = Console.ReadLine();
            byte countId = byte.Parse(Console.ReadLine());
            long thiefId = long.MinValue;

            while (countId > 0)
            {
                string currentId = Console.ReadLine();

                if (numerialType == "sbyte")
                {
                    try
                    {
                        long currentIdNum = sbyte.Parse(currentId);
                        thiefId = Math.Max(currentIdNum, thiefId);
                    }
                    catch
                    {

                    }
                }

                if (numerialType == "int")
                {
                    try
                    {
                        long currentIdNum = int.Parse(currentId);
                        thiefId = Math.Max(currentIdNum, thiefId);
                    }
                    catch
                    {

                    }
                }

                if (numerialType == "long")
                {
                    try
                    {
                        long currentIdNum = long.Parse(currentId);
                        thiefId = Math.Max(currentIdNum, thiefId);
                    }
                    catch
                    {

                    }
                }

                countId--;
            }

            Console.WriteLine(thiefId);
        }
    }
}
