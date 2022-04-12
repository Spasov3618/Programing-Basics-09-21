using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Баскетболни кецове – цената им е 40 % по - малка от таксата за една година
            //•	Баскетболен екип – цената му е 20 % по - евтина от тази на кецовете
            //•	Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип
            //•	Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка
            //Вход
            //От конзолата се четe 1 ред:
            //•	Годишната такса за тренировки по баскетбол – цяло число в интервала[0… 9999]
            //Изход
            //Да се отпечата на конзолата колко ще са разходите на Джеси, ако започне да спортува баскетбол. Сумата да бъде форматирана до втория знак след десетичния знак
            double taxYear = double.Parse(Console.ReadLine());
            double priceSnikars = taxYear * 0.6;
            double ekip = priceSnikars * 0.8;
            double ball = ekip / 4;
            double aksesoari = ball / 5;
            double total = taxYear + priceSnikars + ekip + ball + aksesoari;
            Console.WriteLine($"{total:f2}");
        }
    }
}
