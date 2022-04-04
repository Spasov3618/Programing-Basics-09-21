using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            //           •	Цената на един литър гориво е 2.10 лв.
            //•	Цената за екскурзовод е 100лв.
            //•	В зависимост от деня има отстъпки от общата цена - за събота 10 %, а за неделя 20 %
            // Вход
            //От конзолата се четат 3 реда:
            //•	Бюджет – реално число в интервала[0.00… 10000.00]
            //•	Колко литра гориво ще са им нужни – реално число в интервала[1.00… 50.00]
            //•	Ден от седмицата – текст с възможности "Saturday" и "Sunday"
            //Изход
            //Да се отпечата на конзолата един ред:  
            //•	Ако бюджетът е достатъчен:
            //"Safari time! Money left: {колко пари са им останали} lv. "
            //•	Ако бюджетът не е достатъчен:
            //            "Not enough money! Money needed: {колко пари не им достигат} lv."
            //Сумите трябва да са форматирани до втория знак след десетичната запетая
            double budjet = double.Parse(Console.ReadLine());
            double litersGasolin = double.Parse(Console.ReadLine());
            string dayWeek = Console.ReadLine();
            double total = 100 + litersGasolin * 2.10;
            if (dayWeek== "Saturday")
            {
                total *= 0.9;
            }
            else if (dayWeek == "Sunday")
            {
                total *= 0.8;
            }
            double differents = budjet - total;
            if (budjet>=total)
            {
                Console.WriteLine($"Safari time! Money left: {differents:f2} lv. ");
            }
            else
            {
                double dif = total - budjet;
                Console.WriteLine($"Not enough money! Money needed: {dif:f2} lv.");  
            }
        }
    }
}
