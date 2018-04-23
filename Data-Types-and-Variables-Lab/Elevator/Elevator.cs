﻿using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)person / capacity);

            Console.WriteLine(courses);
        }
    }
}
