using System;

namespace X
{
    class X
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string ex = "x";
            int countEmptySpase = n - 2;
            string emptySpace = new string(' ', countEmptySpase);

            Console.WriteLine($"{ex}{emptySpace}{ex}");

            for (int i = 0; i < n / 2 - 1; i++)
            {
                
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");

                for (int ki = 0; ki < ((n - 4) - i * 2); ki++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("x");
            }

            Console.WriteLine(new string(' ', n / 2) + ex + new string(' ', n / 2));

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < (n / 2 - 1) - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(ex);

                for (int k = 0; k <= i * 2; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(ex);
            }

        }

    }
    
}
