﻿using System;

namespace Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else if(grade<=2.99)
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
