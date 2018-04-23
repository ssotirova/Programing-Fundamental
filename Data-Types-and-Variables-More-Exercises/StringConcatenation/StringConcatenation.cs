﻿using System;

namespace StringConcatenation
{
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            string separator = Console.ReadLine();
            byte remainder = Console.ReadLine() == "even" ? (byte)0 : (byte)1;
            byte stringsCount = byte.Parse(Console.ReadLine());
            string concatenatedString = "";

            for (int i = 1; i <= stringsCount; i++)
            {
                if (i % 2 == remainder)
                {
                    concatenatedString += Console.ReadLine() + separator;
                }
                else
                {
                    Console.ReadLine();
                }
            }

            Console.WriteLine(concatenatedString.Remove(concatenatedString.Length - 1));
        }
    }
}
