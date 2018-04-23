using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = nums.OrderByDescending(x => x).Take(3);

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
