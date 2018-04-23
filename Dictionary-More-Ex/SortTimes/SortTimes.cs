using System;
using System.Linq;

namespace SortTimes
{
    class SortTimes
    {
        static void Main(string[] args)
        {
            var hours = Console.ReadLine().Split().OrderBy(x => x).ToList();
            
            Console.WriteLine(string.Join(", ",hours));
        }
    }
}
