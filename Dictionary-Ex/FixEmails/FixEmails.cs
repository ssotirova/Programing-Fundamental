using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main()
    {
        var emailRegister = new Dictionary<string, string>();
        string personName = Console.ReadLine();

        while (!personName.ToLower().Equals("stop"))
        {
            string email = Console.ReadLine();
            string emailDomain = email.Substring(email.Length - 2).ToLower();

            if (!emailDomain.Equals("uk") && !emailDomain.Equals("us"))
            {
                emailRegister[personName] = email;
            }

            personName = Console.ReadLine();
        }

        foreach (var pair in emailRegister)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }

    }
}