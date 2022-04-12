using System;

namespace Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Бабата на Деси всяка година приготвя обяд за семейството си за Великден.
            //Напишете програма, която изчислява какви разходи ще има по приготвянето на обяда,
            //като знаете колко броя козунаци, кори с яйца и килограма курабии е купила.  Цените на продуктите са следните:
            //•	Козунак  – 3.20 лв.
            //•	Яйца –  4.35 лв.за кора с 12 яйца
            //•	Курабии – 5.40 лв.за килограм
            //•	Боя за яйца - 0.15 лв.за яйце
            //Вход
            //От конзолата се четат 3 реда:
            //•	Брой козунаци -цяло число в интервала[0 … 99]
            //•	Брой кори с яйца -цяло число в интервала[0 … 99]
            //•	Килограми курабии -цяло число в интервала[0 … 99]
            //Изход
            //Да се отпечата на конзолата колко ще са разходите по приготвянето на обяда. Сумата да бъде форматирана до втория знак след десетичната запетая.
            int numEasterBread = int.Parse(Console.ReadLine());
            int numEggs = int.Parse(Console.ReadLine());
            double cookies = double.Parse(Console.ReadLine());
            double priceBred = 3.20;
            double priceEggs = 4.35;
            double priceColor = 0.15*12;
            double priceCookies = 5.40;
            double total = numEasterBread * priceBred + numEggs * (priceEggs + priceColor) + cookies * priceCookies;
            Console.WriteLine($"{total:f2}");
        }
    }
}
