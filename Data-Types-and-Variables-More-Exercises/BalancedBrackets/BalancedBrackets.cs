using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countLeft = 0;
            int countRight = 0;

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                if (text == "(")
                {
                    countLeft++;
                    if (countLeft - countRight >1)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                else if (text == ")")
                {
                    countRight++;
                    if (countLeft - countRight != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }

            if (countLeft == countRight)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
