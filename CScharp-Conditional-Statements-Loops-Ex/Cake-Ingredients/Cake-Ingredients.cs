using System;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredients = Console.ReadLine();
            int count = 0;

            while (ingredients != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredients}.");
                count++;
                ingredients = Console.ReadLine();
            
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");

        }
    }
}
