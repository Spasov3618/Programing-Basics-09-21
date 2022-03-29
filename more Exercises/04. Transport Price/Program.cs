using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            //Студент трябва да пропътува n километра. Той има избор измежду три вида транспорт:
            //	Такси.Начална такса: 0.70 лв.Дневна тарифа: 0.79 лв. / км.Нощна тарифа: 0.90 лв. / км.
            //	Автобус.Дневна / нощна тарифа: 0.09 лв. / км.Може да се използва за разстояния минимум 20 км.
            //	Влак.Дневна / нощна тарифа: 0.06 лв. / км.Може да се използва за разстояния минимум 100 км.
            //Напишете програма, която въвежда броя километри n и период от деня(ден или нощ) и изчислява цената на най - евтиния транспорт.
            //Вход
            //От конзолата се четат два реда:
            //•	Първият ред съдържа числото n – брой километри – цяло число в интервала[1…5000]
            //•	Вторият ред съдържа дума “day” или “night” – пътуване през деня или през нощта
            //Изход
            //Да се отпечата на конзолата най - ниската цена за посочения брой километри, форматирана до втория знак след десетичния разделител.
            double km = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double price = 0;
            double priceBus = km * 0.09;
            double priceTren = km * 0.06;
            if (day == "day")
            {
                double pricetaxi = 0.7 + km * 0.79;
                price = pricetaxi;
            }
            else if (day == "night")
            {
                double priceTaxiNight = 0.7 + km * 0.9;
                price = priceTaxiNight;
            }
                if (km < 20)
                {
                    Console.WriteLine($"{price:f2}");
                }
                else if (km >= 20 && km < 100)
                {
                    Console.WriteLine($"{priceBus:f2}");
                }
                else
                {
                    Console.WriteLine($"{priceTren:f2}");
                }
            
        }
    }
}
