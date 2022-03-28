using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            double vacancion = double.Parse(Console.ReadLine());
            double currmoney = double.Parse(Console.ReadLine());

            int days = 0;
            int spend = 0;
            while (spend != 5)
            {
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;
                if (input == "save")
                {
                    currmoney += money;
                    spend = 0;
                }

                else if (input == "spend")
                {
                    spend++;
                    if (money > currmoney)
                    {
                        currmoney = 0;
                    }
                    else
                    {
                        currmoney -= money;
                    }
                }
                if (currmoney >= vacancion)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
            }
            if (spend == 5)
            {
                Console.WriteLine("You can't save the money.");

                Console.WriteLine($"{days}");
            }
        }
    }
}
