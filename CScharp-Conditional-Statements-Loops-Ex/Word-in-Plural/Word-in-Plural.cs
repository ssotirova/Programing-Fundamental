using System;

namespace Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string newWord;
            
            bool wordY = word.EndsWith("y");  // проверка дали завършва на "Y"
            bool wordZ = word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z") || word.EndsWith("ch") || word.EndsWith("sh");
            
            if (wordY == true)
            {
                newWord = word.Remove(word.Length - 1, 1);  // премахва последните n-символa от стринга       
                Console.WriteLine($"{newWord}ies");
            }
            else if (wordZ == true)
            {
                Console.WriteLine($"{word}es");
            }
            else
            {
                Console.WriteLine($"{word}s");

            }
            
        }
    }
}
