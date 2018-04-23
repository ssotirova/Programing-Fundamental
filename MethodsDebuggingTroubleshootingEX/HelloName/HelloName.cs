using System;

namespace HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintHelloName(name);
            Console.WriteLine($"Hello, {name}!");
        }

        static string PrintHelloName(string name)
        {
            return name;            
        }
    }
}
