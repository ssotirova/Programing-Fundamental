﻿using System;

namespace Number_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");                
            }
        }
    }
}
