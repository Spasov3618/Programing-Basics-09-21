using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            double finalmoney = 0;
            if (budjet <= 100)
            {
                if (season == "summer")
                {
                    finalmoney = budjet * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {finalmoney:f2}");
                }
                else
                {
                    finalmoney = budjet * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {finalmoney:f2} ");
                }
            }
            else if (budjet > 100 && budjet <= 1000)
            {
                if (season == "summer")
                {
                    finalmoney = budjet * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {finalmoney:f2}");
                }
                else
                {
                    finalmoney = budjet * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {finalmoney:f2} ");
                }
            }
            else if (budjet > 1000)
            {
                finalmoney = budjet * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {finalmoney:f2} ");
            }
        }
    }
}
