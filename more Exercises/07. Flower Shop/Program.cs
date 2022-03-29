using System;

namespace _07._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //           •	Магнолии – 3.25 лева
            //•	Зюмбюли – 4 лева
            //•	Рози – 3.50 лева
            //•	Кактуси – 8 лева
            //От общата сума, Мария трябва да плати 5 % данъци.
            const double magnolii = 3.25;
            const double zumbul = 4.00;
            const double rozi = 3.50;
            const double kaktus = 8.00;

            double numMagnolii = double.Parse(Console.ReadLine());
            double numZumbul = double.Parse(Console.ReadLine());
            double numRoza = double.Parse(Console.ReadLine());
            double numKaktus = double.Parse(Console.ReadLine());
            double pricePodarak = double.Parse(Console.ReadLine());
            double priseMagnolii = magnolii * numMagnolii;
            double priseZumbul = zumbul * numZumbul;
            double priseRozi = rozi * numRoza;
            double priseKaktus = kaktus * numKaktus;
            double totalprice = priseMagnolii + priseZumbul + priseRozi + priseKaktus;
            double total = totalprice * 0.05;
            totalprice -= total;
            //•	Ако парите СА стигнали: "She is left with {останали} leva." – сумата трябва да е закръглена към по - малко цяло число(пр. 1.90-> 1).
            if (totalprice >= pricePodarak)
            {
                double left = totalprice - pricePodarak;
                Console.WriteLine($"She is left with {Math.Floor(left)} leva.");
            }
            else
            {
                double different =  pricePodarak - totalprice ;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(different)} leva.");
            }


            // Cума = 2 * 3.25 + 3 * 4 + 5 * 3.5 + 1 * 8 = 44 лева
            // Данъци = 5 % от 44 = 2.20.Печалба - 41.80 лева
            //50 – 41.80 = 8.20 лева недостигнали


        }
    }
}
