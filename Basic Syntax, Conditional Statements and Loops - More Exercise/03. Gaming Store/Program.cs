using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //На първия ред ще получите текущия си баланс – число с плаваща запетая в диапазона[0, 00…5000, 00].
            //Докато не получите командата „Време за игра“, трябва да продължите да купувате игри. Когато се купи игра, балансът на потребителя намалява с цената на играта.
            //Освен това програмата трябва да отговаря на следните условия:
            //• Ако игра, която потребителят се опитва да купи, не присъства в таблицата по - горе, отпечатайте „Не е намерено“ и прочетете следващия ред.
            //• Ако в който и да е момент на потребителя са останали $0, отпечатайте "Изчерпани пари!" и приключи програмата.
            //• Като алтернатива, ако потребителят се опитва да купи игра, която не може да си позволи, отпечатайте „Твърде скъпо“ и прочетете следващия ред.
            //• Ако играта съществува и играчът има парите за нея, отпечатайте „Bought { nameOfGame}“
            //Когато получите „Време за игра“, отпечатайте оставащите пари на потребителя и общата сума, похарчена за игри, закръглени до 2 - ри знак след десетичната запетая. 
            double budjet = double.Parse(Console.ReadLine());
            string nameOfGame = Console.ReadLine();
            double money = 0;
            while (nameOfGame != "Game Time")
            {
                if (nameOfGame == "OutFall 4")
                {
                    if (budjet < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budjet -= 39.99;
                        money += 39.99;
                        Console.WriteLine($"Bought {nameOfGame}");
                    }
                }
                else if (nameOfGame == "CS: OG")
                {
                    if (budjet < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budjet -= 15.99;
                        money += 15.99;
                        Console.WriteLine($"Bought {nameOfGame}");
                    }
                }
                else if (nameOfGame == "Zplinter Zell")
                {
                    if (budjet < 19.99)
                    {
                        Console.WriteLine("Too Expensive");

                    }
                    else
                    {
                        budjet -= 19.99;
                        money += 19.99;
                        Console.WriteLine($"Bought {nameOfGame}");
                    }
                }
                else if (nameOfGame == "Honored 2")
                {
                    if (budjet < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budjet -= 59.99;
                        money += 59.99;
                        Console.WriteLine($"Bought {nameOfGame}");
                    }
                }
                else if (nameOfGame == "RoverWatch")
                {
                    if (budjet < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budjet -= 29.99;
                        money += 29.99;
                        Console.WriteLine($"Bought {nameOfGame}");
                    }
                }
                else if (nameOfGame == "RoverWatch Origins Edition")
                {
                    if (budjet < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budjet -= 39.99;
                        money += 39.99;
                        Console.WriteLine($"Bought {nameOfGame}");
                    }
                }
            
                else
                {
                    Console.WriteLine("Not Found");
                    
                }
                                
                nameOfGame = Console.ReadLine();
                if (budjet==0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            if (nameOfGame == "Game Time")
            {
                Console.WriteLine($"Total spent: ${money:f2}. Remaining: ${budjet:f2}");
            }
        }
    }
}
