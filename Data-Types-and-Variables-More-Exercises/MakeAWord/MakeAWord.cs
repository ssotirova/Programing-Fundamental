using System;

namespace MakeAWord
{
    class MakeAWord
    {
        static void Main(string[] args)
        {
            int countWord = int.Parse(Console.ReadLine());
            var finalWord = "";

            for (int i = 0; i < countWord; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                finalWord += letter;
            }

            Console.WriteLine($"The word is: {finalWord}");
        }
    }
}
