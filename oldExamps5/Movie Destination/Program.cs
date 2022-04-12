using System;

namespace Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Дестинация
            //       Сезон   Dubai       Sofia       London
            //Winter        45 000 lv.  17 000 lv.  24 000 lv.
            //Summer        40 000 lv.  12 500 lv.  20 250 lv.

            //            Съществуват следните данъчни облекчения/ облагания:
            //•	Ако дестинацията е Дубай – 30 % отстъпка от крайната цена
            //•	Ако дестинацията е София – цената се оскъпява с 25 %

            //1.Бюджет на филма – реално число в диапазона[100 000.0… 2 000 000.0]
            //2.Дестинация – текст, с възможности "Dubai", "Sofia" и "London"
            //3.Сезон – текст, с възможности "Summer" и "Winter"
            //4.Брой дни  – цяло число в диапазона[1… 40]
            //Изход
            //На конзолата да се отпечата един ред:
            //•	Ако бюджета е достатъчен: 
            //"The budget for the movie is enough! We have {остатък от бюджета} leva left!"
            //•	  Ако бюджета НЕ е достатъчен:
            //"The director needs {нужна сума} leva more!"
            //Резултатът да се закръгли до втората цифра след десетичния знак.

            double budjet = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            double numDay = double.Parse(Console.ReadLine());
            double total = 0;
            switch (destination)
            {
                case "Dubai":
                    if (season == "Winter")
                    {
                        total = (45000 * 0.7) *numDay;
                    }
                    else if (season == "Summer")
                    {
                        total = (40000 * 0.7)*numDay;
                    }
                    break;
                case "Sofia":
                    if (season == "Winter")
                    {
                        total = numDay* (17000 + (17000 * 0.25));
                    }
                    else if (season == "Summer")
                    {
                        total =numDay* (12500+ (12500* 0.25));
                    }
                    break;
                case "London":
                    if (season == "Winter")
                    {
                        total = 24000 * numDay;
                    }
                    else if (season == "Summer")
                    {
                        total = 20250 * numDay;
                    }
                    break;
            }
            if (budjet>= total)
            {
                double left = budjet - total;
                Console.WriteLine($"The budget for the movie is enough! We have {left:f2} leva left!");
            }
            else
            {
                double need = total - budjet;
                Console.WriteLine($"The director needs {need:f2} leva more!");
            }

        }
    }
}
