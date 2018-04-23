using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            string pattern = @"(<p>)+[^<>]+(<\/p>)";
            Regex reg = new Regex(pattern);

            var matches = reg.Matches(text);
            var words = new List<string>();
            foreach (var item in matches)
            {
                string word = item.ToString();
                word = word.Remove(0, 3);
                word = word.Remove(word.Length - 4);
                words.Add(word.Trim());
            }
            string replacePattern = @"[^a-z0-9]";
            Regex replaceReg = new Regex(replacePattern);
            for (int i = 0; i < words.Count; i++)
            {
                string letter = replaceReg.Replace(words[i], " ");
                var buildLetter = new StringBuilder();
                for (int j = 0; j < letter.Length; j++)
                {

                    if (letter[j] >= 'a' && letter[j] <= 'm')
                    {
                        char newChar = Convert.ToChar(letter[j] - 'a' + 'n');
                        buildLetter.Append(newChar);
                    }
                    else if (letter[j] >= 'n' && letter[j] <= 'z')
                    {
                        char newChar = Convert.ToChar(letter[j] - 'n' + 'a');
                        buildLetter.Append(newChar);
                    }
                    else
                    {
                        buildLetter.Append(letter[j]);
                    }

                }

                var helper = buildLetter
                    .ToString()
                    .Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                words[i] = string.Join(" ", helper);
            }

            foreach (var item in words)
            {
                Console.Write(item + " ");
            }

        }
    }
}