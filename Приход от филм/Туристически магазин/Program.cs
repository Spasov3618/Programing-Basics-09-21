using System;

namespace Туристически_магазин
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Времето се затопля и туристите започват да си правят разходки високо в планината, където все още има сняг, като за целта те трябва да закупят нужната туристическа екипировка.
            //Вашата задача е да напишете програма, която да изчислява, стойността на екипировката, както и дали определения бюджет е достатъчен или не, като се знае, че в магазина има следната промоция: Всеки трети продукт е на половин цена.
            //Вход
            //От конзолата се чете:
            //•	На първи ред – бюджетът - реално число в интервала[1.00… 100000.00]
            //•	След това поредица от два реда(до получаване на команда "Stop" или при заявка за купуване на продукт, чиято стойност е по-висока от наличния бюджет) :
            //o Име на продукта – текст
            //o   Цена на продукта – реално число в интервала[1.00… 5000.00]
            //Изход
            //На конзолата да се отпечатат следните редове според случая:
            //•	При получаване на командата "Stop", на един ред:
            //            o   "You bought {брой на закупените продукти} products for {цена на покупките} leva."
            //•	При заявка за покупка на продукт, чиято цена е по - висока от останалите пари, на два реда:
            //            o   "You don't have enough money!"
            //o   "You need {недостигащи пари} leva!"
            double budjet = double.Parse(Console.ReadLine());
            double counter = 0;
            double price = 0;
            string nameProdukt = Console.ReadLine();
            while (nameProdukt != "Stop" )
            {
                double priceProdukt = double.Parse(Console.ReadLine());
                counter++;
                if (counter % 3 ==0)
                {
                    priceProdukt /= 2;
                    budjet -= priceProdukt;
                    price += priceProdukt;
                }
                else
                {
                    budjet -= priceProdukt;
                    price += priceProdukt;
                }
                if (budjet<0)
                {
                    break;
                }
                nameProdukt = Console.ReadLine();
                if (nameProdukt == "Stop")
                {
                    break;
                }
            }
            if (nameProdukt == "Stop")
            {
                Console.WriteLine($"You bought {counter} products for {price:f2} leva.");
            }
            if (budjet<0)
            {
           
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {Math.Abs(budjet):f2} leva!");
            }

        }
    }
}
