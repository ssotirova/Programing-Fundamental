using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string word = "World";
            object variable1 = hello + " " + word;
            string variable2 = (string)variable1;

            Console.WriteLine(variable1);
        }
    }
}
