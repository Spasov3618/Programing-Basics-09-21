using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double vip = 499.99;
            const double normal = 249.99;
            double budjet = double.Parse(Console.ReadLine());
            string tiket = Console.ReadLine();
            double people = double.Parse(Console.ReadLine());
            double priceTiket = 0;
            double transport = 0;
            double tiketVip = people * vip;
            double tiketNormal = people * normal;
            if (people <= 4)
            {
                transport = budjet * 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                transport = budjet * 0.6;
            }
            else if (people >= 10 && people <= 24)
            {
                transport = budjet * 0.5;
            }
            else if (people >= 25 && people <= 49)
            {
                transport = budjet * 0.4;
            }
            else
            {
                transport = budjet * 0.25;
            }
            switch (tiket)
            {
                case "VIP":
                    priceTiket = budjet - transport - tiketVip;
                    break;
                case "Normal":
                    priceTiket = budjet - transport - tiketNormal;
                    break;
            }
            if (priceTiket >= 0)
            {

                Console.WriteLine($"Yes! You have {priceTiket:f2} leva left.");
            }
            else
            {
                double different = Math.Abs(priceTiket);
                Console.WriteLine($"Not enough money! You need {different:f2} leva.");
            }
        }
    }
}        
