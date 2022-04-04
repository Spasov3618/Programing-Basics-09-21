using System;

namespace Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	цената на малините е на половина по - ниска от тази на ягодите;
            //•	цената на портокалите е с 40 % по - ниска от цената на малините;
            //•	цената на бананите е с 80 % по - ниска от цената на малините.
            //Вход
            //От конзолата се четат 5 реда:
            //            1.Цена на ягодите в лева – реално число в интервала[0.00 … 10000.00]
            //2.Количество на бананите в килограми – реално число в интервала[0.00 … 1 0000.00]
            //3.Количество на портокалите в килограми – реално число в интервала[0.00 … 10000.00]
            //4.Количество на малините в килограми – реално число в интервала[0.00 … 10000.00]
            //5.Количество на ягодите в килограми – реално число в интервала[0.00 … 10000.00]
            //Изход
            //Да се отпечата на конзолата едно число:
            //•	парите, които са необходими на Мария.
            //Резултатът да се форматира до вторта цифра след десетичната запетая.
            double priseBerries = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());
            double berries = double.Parse(Console.ReadLine());
                double priceRaspberries = priseBerries / 2;
            double priceOranges = priceRaspberries * 0.6;
            double priseBananas = priceRaspberries*0.2;
            double total = priseBerries * berries + priseBananas * bananas + priceOranges * oranges + priceRaspberries * raspberries;
            Console.WriteLine($"{total:f2}");
        }
    }
}
