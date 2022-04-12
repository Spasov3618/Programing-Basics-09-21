using System;

namespace Easter_Guests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Любо очаква гости за Великден.Той разполага с определен бюджет, който е предвидил, за да купи козунаци и боядисани яйца.Известно е, че един козунак стига за трима човека, като всеки гост ще получи и по 2 яйца.Вашата задача е да намерите колко козунака и яйца трябва да купи Любо, както и каква ще е сумата, която той трябва да плати и дали бюджета му е достатъчен. При изчисляването на броя козунаци, които Любо трябва да закупи, техният брой трябва да се закръгли към по-голямото цяло число.  Ако парите не му стигат, трябва да се изведе съобщение, колко не му достигат.
            //Известно е, че:
            //•	Един козунак струва 4лв.
            //•	Едно яйце струва 0.45лв.
            //Вход
            //От конзолата се четат 2 реда:
            //•	На първия ред са броят на гостите – цяло число в интервала[0... 200000]
            //•	На втория ред е бюджетът с който разполага Любо  – цяло число в интервала[0... 200000]
            //Изход
            //На конзолата да се отпечатат два реда:
            //•	Ако бюджетът е достатъчен:
            //o   "Lyubo bought {брои закупени козунаци} Easter bread and {брои закупени яйца} eggs."
            //o   "He has {останали пари} lv. left."
            //•	Ако бюджетът НЕ Е достатъчен:
            //            o   "Lyubo doesn't have enough money."
            //o   "He needs {недостигащи пари} lv. more."
            //Парите да бъдат форматирани до втората цифра след десетичния знак.
            double numGuests = double.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());
            double numBread = Math.Ceiling(numGuests / 3);
            const double priceBread = 4;
            const double priceEggs = 0.45;
            double numEggs = numGuests * 2;
            double total = numBread * priceBread + numEggs * priceEggs;
            double left = budjet - total;
            double needMoney = total - budjet;
            if (budjet>= total)
            {
                Console.WriteLine($"Lyubo bought {numBread} Easter bread and {numEggs} eggs.");
                Console.WriteLine($"He has {left:f2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {needMoney:f2} lv. more.");
            }
        }
    }
}
