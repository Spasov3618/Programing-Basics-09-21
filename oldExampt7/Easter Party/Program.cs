using System;

namespace Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            //Деси има рожден ден на Великден и иска да организира парти за своите приятели.
            //Тя знае какъв е броят гости, които иска да покани и колко е кувертът за всеки гост. От броя гости зависи и каква отстъпка ще получи за куверта за един човек.

            //Ако покани:
            //•	Между 10(вкл.) и 15(вкл.) човека-> 15 % отстъпка от куверта за един човек
            //•	Между 15 и 20(вкл.) човека-> 20 % отстъпка от куверта за един човек
            //•	Над 20 човека-> 25 % отстъпка от куверта за един човек
            //Деси трябва да предвиди и закупуването на торта за партито.Цената на тортата е 10 % от бюджета на Деси.
            //Напишете програма, която изчислява дали бюджетът на Деси ще и е достатъчен за партито.

                        
            //Изход
            //На конзолата да се отпечата един ред:
            //•	Ако бюджетът  е достатъчен:
            //o   "It is party time! {останали пари} leva left."
            //•	Ако бюджетът не е достатъчен:
            //            o   "No party! {недостигащи пари} leva needed."
            //Резултатът да бъде форматиран до втория знак след десетичната запетая.
            int numGuests = int.Parse(Console.ReadLine());
            double priceEnvelope = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double priceCake = budget * 0.1;
            if (numGuests>=10&&numGuests<=15)
            {
                priceEnvelope *= 0.85;
            }
            else if (numGuests>15 && numGuests<=20)
            {
                priceEnvelope *= 0.80;
            }
            else if (numGuests>20)
            {
                priceEnvelope *= 0.75;
            }
            double total = numGuests * priceEnvelope + priceCake;
            if (budget>=total)
            {
                double left = budget - total;
                Console.WriteLine($"It is party time! {left:f2} leva left.");
            }
            else
            {
                double need = total - budget;
                Console.WriteLine($"No party! {need:f2} leva needed.");
            }
        }
    }
}
