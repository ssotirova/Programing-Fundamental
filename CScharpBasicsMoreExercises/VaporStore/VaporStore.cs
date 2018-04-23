using System;

namespace VaporStore
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double price = 0;
            double sum = 0;

            while (true)
            {
                string gameName = Console.ReadLine();

                if (gameName == "Game Time")
                {
                    break;
                }
                else if (gameName == "OutFall 4")
                {
                    price = 39.99;
                    if (currentBalance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "CS: OG")
                {
                    price = 15.99;
                    if (currentBalance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "Zplinter Zell")
                {
                    price = 19.99;
                    if (currentBalance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "Honored 2")
                {
                    price = 59.99;
                    if (currentBalance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "RoverWatch")
                {
                    price = 29.99;
                    if (currentBalance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                    if (currentBalance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if ((gameName != "OutFall 4" || gameName != "CS: OG" || gameName != "Zplinter Zell"
                    || gameName != "Honored 2" || gameName != "RoverWatch" || gameName != "RoverWatch Origins Edition"))
                {
                    Console.WriteLine("Not Found");
                } 
                                               
                sum += price;
               
            }

            if (currentBalance - sum >= 0)
            {
                Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${(currentBalance - sum):f2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
            
        }
    }
}
