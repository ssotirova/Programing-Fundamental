using System;
using System.Linq;

namespace CountNumber
{
    class CountNumber
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            int count = 1;
            int currentElement = nums[0];
            bool isLastElementPrinted = false;
            for (int i = 1; i < nums.Count; i++)
            {
                int nextElement = nums[i];
                if (currentElement == nextElement)
                {
                    count++;
                    if (i == nums.Count - 1)
                    {
                        Console.WriteLine("{0} -> {1}", nextElement, count);
                        isLastElementPrinted = true;
                    }
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", currentElement, count);
                    count = 1;
                }

                currentElement = nums[i];
            }

            if (!isLastElementPrinted)
            {
                Console.WriteLine("{0} -> {1}", currentElement, 1);
            }
        }
    }
}
