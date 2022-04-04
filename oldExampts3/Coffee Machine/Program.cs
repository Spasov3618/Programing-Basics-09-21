using System;

namespace Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            //             Без захар        Нормално            Допълнително захар
            //Еспресо       0.90 лв./ бр.    1 лв. / бр.         1.20 лв. / бр.
            //Капучино      1.00 лв. / бр.    1.20 лв. / бр.     1.60 лв. / бр.
            //Чай             0.50 лв. / бр.   0.60 лв. / бр.     0.70 лв. / бр.
            //Трябва да имате предвид следните отстъпки:
            //•	При избрана напитка без захар има 35 % отстъпка.
            //•	При избрана напитка "Espresso" и закупени поне 5 броя, има 25 % отстъпка.
            //•	При сума надвишава 15 лева, 20 % отстъпка от крайната цена,  
            //Отстъпките се прилагат в реда на тяхното описване.
            //Вход
            //Входът се чете от конзолата и се състои от три реда:
            //•	Първи ред -напитка - текст с възможности"Espresso", "Cappuccino" или "Tea"
            //•	Втори ред -захар - текст  с възможности "Without", "Normal" или "Extra"
            //•	Трети ред -брой напитки - цяло число в интервала[1… 50]
            //Изход
            //На конзолата трябва да се отпечата един ред:
            //            "You bought {брой напитки} cups of {напитка} for {крайна цена} lv."
            //Цената да бъде форматирана до втората цифра след десетичния знак.
            string drink = Console.ReadLine();
            string shugar = Console.ReadLine();
            double numDrinks = double.Parse(Console.ReadLine());
            double price = 0;
            switch (drink )
            {
                case "Espresso":
                    if (shugar=="Without")
                    {
                        price = numDrinks * 0.90;
                        price *= 0.65;
                    }
                    else if (shugar =="Normal")
                    {
                        price = numDrinks * 1;
                    }
                    else if (shugar== "Extra")
                    {
                        price = numDrinks * 1.20;
                    }
                    break;
                case "Cappuccino":
                    if (shugar == "Without")
                    {
                        price = numDrinks * 1.0;
                        price *= 0.65;
                    }
                    else if (shugar == "Normal")
                    {
                        price = numDrinks * 1.20;
                    }
                    else if (shugar == "Extra")
                    {
                        price = numDrinks * 1.60;
                    }
                    break;
                case "Tea":
                    if (shugar == "Without")
                    {
                        price = numDrinks * 0.50;
                        price *= 0.65;
                    }
                    else if (shugar == "Normal")
                    {
                        price = numDrinks * 0.6;
                    }
                    else if (shugar == "Extra")
                    {
                        price = numDrinks * 0.70;
                    }
                    break;
            }
            if (drink == "Espresso" && numDrinks >=5)
            {
                price *= 0.75; 
            }
            if (price> 15)
            {
                price *= 0.8;
            }
            Console.WriteLine($"You bought {numDrinks} cups of {drink} for {price:f2} lv.");
        }
    }
}
