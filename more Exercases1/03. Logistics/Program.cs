using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отговаряте за логистиката на различни товари. В зависимост от теглото на товара е нужно различно превозно средство.
            //Цената на тон, за която се превозва товара е различна за всяко превозно средство:
            //•	До 3 тона – микробус(200 лева на тон)
            //•	От 4 до 11 тона – камион(175 лева на тон)
            //•	12 и повече тона – влак(120 лева на тон)
            //Вашата задача е да изчислите средната цена на тон превозен товар, както и процента на тоновете превозвани с всяко превозно средство,
            //спрямо общото тегло(в тонове) на всички товари.
            //Вход
            //От конзолата се четат поредица от числа, всяко на отделен ред:
            //•	На първия ред – броя на товарите за превоз – цяло число в интервала[1...1000]
            //•	За всеки един товар на отделен ред – тонажа на товара – цяло число в интервала[1...1000]
            //Изход
            //Да се отпечатат на конзолата 4 реда, както следва:
            //•	Първи ред – средната цена на тон превозен товар(закръглена до втория знак след дес. запетая);
            //•	Втори ред – процентът тона превозвани с микробус(процент между 0.00 % и 100.00 %);
            //•	Трети ред – процентът тона превозвани с камион(процент между 0.00 % и 100.00 %);
            //•	Четвърти ред – процентът тона превозвани с влак(процент между 0.00 % и 100.00 %).
            double numTovar = double.Parse(Console.ReadLine());
            double tovarBus = 0;
            double tovarTruk = 0;
            double tovarTren = 0;
            double priceBus = 0;
            double priceTruk = 0;
            double priceTren = 0;
            for (int i = 0; i < numTovar; i++)
            {
                double input = double.Parse(Console.ReadLine());
                if (input <= 3)
                {
                    tovarBus += input;
                    priceBus += input * 200;
                }
                else if (input >= 4 && input <= 11)
                {
                    tovarTruk += input;
                    priceTruk += input * 175;
                }
                else if (input >= 12)
                {
                    tovarTren += input;
                    priceTren += input * 120;
                }
            }
                double totalTovar = tovarBus + tovarTruk + tovarTren;
                double price = priceBus + priceTruk + priceTren;
                double average = price / totalTovar;
                double procentBus = tovarBus / totalTovar * 100;
                double procentTruk = tovarTruk / totalTovar * 100;
                double procentTren = tovarTren / totalTovar * 100;
                Console.WriteLine($"{average:f2}");
                Console.WriteLine($"{procentBus:f2}%");
                Console.WriteLine($"{procentTruk:f2}%");
                Console.WriteLine($"{procentTren:f2}%");

            
            

           
        }
    }
}
