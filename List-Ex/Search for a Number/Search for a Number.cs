﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> takenNums = new List<int>();
            takenNums = numbers;

            for (int i = 0; i < nums[0]; i++)
            {
                while (nums[1] > 0)
                {
                    nums[1]--;
                    takenNums.RemoveAt(0);
                }
            }
            if (takenNums.Contains(nums[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
