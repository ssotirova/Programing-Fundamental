﻿using System;
using System.Collections.Generic;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>();

            for (int i = 1; ; i++)
            {
                string resource = Console.ReadLine();

                if (resource.Equals("stop"))
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());
                                
                if (!myDict.ContainsKey(resource))
                {
                    myDict.Add(resource, 0);
                }
                                
                myDict[resource] += quantity;
            }

            foreach (var item in myDict)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}