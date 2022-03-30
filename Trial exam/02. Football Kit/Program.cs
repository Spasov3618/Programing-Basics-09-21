using System;

namespace _02._Football_Kit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Като един истински запалянко Пепи решил да се подготви за световното първенство, като си закупи екип на любимия си футболен отбор.
            //В магазина, в който пазарувал предлагали тениски, шорти, чорапи и бутонки.
            //Знае се, че цената на шортите е 75 % от цената на тениските,
            //а цената на чорапите е 20 % от цената на шортите.
            //Бутонките струват два пъти колкото тениската и шортите взети заедно.
            //Тъй като Пепи редовно пазарува от този магазин, той има карта за отстъпка на стойност 15 % от общата сума на покупката.
            //Ако сметката на Пепи е по-висока или равна на дадена сума, той получава подарък – точно копие на топката от световното.
            //Напишете програма, която изчислява дали Пепи е спечелил топката. 
           
            //Изход:
            //            На конзолата се отпечатват два реда:
            //•	Ако топката Е спечелена:
            //o   "Yes, he will earn the world-cup replica ball!"
            //o   "His sum is {сумата} lv."
            //•	Ако топката НЕ Е спечелена:
            //            o   "No, he will not earn the world-cup replica ball."
            //o   "He needs {недостигащи пари} lv. more."
            //Резултатът да бъде форматиран до втората цифра след десетичната запетая.
            double priceTshirt = double.Parse(Console.ReadLine());
            double sumBonus = double.Parse(Console.ReadLine());
            double priseShorts = priceTshirt * 0.75;
            double priseSocks = priseShorts * 0.20;
            double priseButtons = (priceTshirt + priseShorts) * 2;
            double totalMoney = priceTshirt + priseShorts + priseSocks + priseButtons;
            double total = totalMoney * 0.85;
            if (totalMoney >=sumBonus)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {total:f2} lv.");
            }
            else
            {
                double different = sumBonus - total;
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {different:f2} lv. more.");
            }

        }
    }
}
