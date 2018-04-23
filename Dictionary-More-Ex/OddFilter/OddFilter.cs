﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OddFilter
{
    class OddFilter
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .ToList();
            var numListAvetage = numList.Average();
            numList = numList.Select(x => x = x > numListAvetage ? ++x : --x)
                .ToList();
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
