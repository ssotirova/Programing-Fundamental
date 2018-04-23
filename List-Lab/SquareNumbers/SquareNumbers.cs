﻿using System;
using System.Collections.Generic;
using System.Linq;

class SquareNumbers
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToList();
        var result = new List<int>();

        foreach (var num in input)
        {
            if (Math.Sqrt(num) == Math.Floor(Math.Sqrt(num)))
            {
                result.Add(num);
            }
        }
        result.Sort();
        result.Reverse();
        Console.WriteLine(string.Join(" ", result));
    }
}