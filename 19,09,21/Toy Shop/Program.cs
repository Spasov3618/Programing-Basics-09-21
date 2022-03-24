using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Пъзел - 2.60 лв.
            const double puzlePrice = 2.60;
            const double barbiPrice = 3.00;
            const double bearPrice = 4.10;
            const double minionPrice = 8.20;
            const double trucPrice = 2.00;
            double holidei = double.Parse(Console.ReadLine());
            double pcPuzle = double.Parse(Console.ReadLine());
            double pcbarbi = double.Parse(Console.ReadLine());
            double pcbear = double.Parse(Console.ReadLine());
            double pcminion = double.Parse(Console.ReadLine());
            double pctruc = double.Parse(Console.ReadLine());
            double price = puzlePrice * pcPuzle + barbiPrice * pcbarbi + bearPrice * pcbear + minionPrice * pcminion + trucPrice * pctruc;  
           
            if (pcbarbi + pcbear + pcminion + pcPuzle + pctruc >= 50)
            {
                price = price * 0.75;
            }
            double rent = price * 0.10;
            double totalprice = price - rent;
            double differens = (Math.Abs (holidei - totalprice));
            if (totalprice >= holidei )
            {
                Console.WriteLine($"Yes! {differens:f2} lv left.");
            }
            else
                Console.WriteLine($"Not enough money! {differens:f2} lv needed.");
        }
    }
}
