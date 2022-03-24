using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int stuntman = int.Parse(Console.ReadLine());
            double priceForClothesPerPerson = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.10;
            double totalPriceForClothesPerPerson = stuntman * priceForClothesPerPerson;

            if (stuntman > 150)
            {
                totalPriceForClothesPerPerson *= 0.90;

            }
            double totalMoney = decorPrice + totalPriceForClothesPerPerson;

            if (totalMoney > budget)
            {
                double neededMoney = totalMoney - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }
            else
            {
                double moneyLeft = budget - totalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            }
    }
}
