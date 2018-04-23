using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConvertBase10ToBaseN
{
    class ConvertBaseNToBase10
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine();
            List<BigInteger> nums = data.Split().Select(BigInteger.Parse).ToList();
            List<BigInteger> res = new List<BigInteger>();
            BigInteger baseNum = nums[0];
            BigInteger number = nums[1];

            while (number != 0)
            {
                var result = number % baseNum;
                res.Add(result);
                number = number / baseNum;
            }
            var revRes = string.Join("", res);
            revRes = new string(revRes.Reverse().ToArray());
            Console.WriteLine(revRes);
        }
    }
}
