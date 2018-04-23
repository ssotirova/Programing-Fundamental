using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower()
                .Split(new char[]
                {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '},StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length < 5)
                .OrderBy(word => word)
                .Distinct()
                .ToList();
                       
            
            Console.WriteLine(string.Join(", ", words));

        }
    }
}
