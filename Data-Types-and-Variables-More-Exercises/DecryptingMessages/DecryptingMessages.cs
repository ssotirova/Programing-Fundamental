using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int countLetters = int.Parse(Console.ReadLine());
            string convertedWord = "";

            for (int i = 0; i < countLetters; i++)
            {
                char oneLetter = char.Parse(Console.ReadLine());
                int oneLetterASKII = Convert.ToInt32(oneLetter) + key;
                char convertedLetter = Convert.ToChar(oneLetterASKII);

                convertedWord += convertedLetter;
                
            }
            
            Console.WriteLine(convertedWord);
        }
    }
}
