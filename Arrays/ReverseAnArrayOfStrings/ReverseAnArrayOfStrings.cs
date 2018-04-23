using System;
using System.Linq;

namespace ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < nums.Length / 2; i++)
            {
                string temp = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = temp;
            }
       
            Console.WriteLine(string.Join(" ", nums));

            
        }
    }
}
