﻿using System;

namespace NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            number = ReverseNumber(number);
            Console.WriteLine(number);
        }

        static string ReverseNumber(string number)
        {
            char[] reversed = number.ToCharArray();
            Array.Reverse(reversed);
            reversed.ToString();
            return new string(reversed);
        }
    }
}
