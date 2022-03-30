using System;

namespace Семейна_почивка
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Семейство Иванови планират семейната си почивка. Вашата задача е да напишете програма,
            //  която да изчислява дали предвидения от тях бюджет ще им стигне, като знаете колко нощувки са планирали,
            //  каква е цената за нощувка и колко процента от бюджета са предвидили за допълнителни разходи.
            //  Трябва да се има предвид, че ако броят на нощувките е по - голям от 7, цената за нощувка се намаля с 5 %.
            //Вход
            //От конзолата се четат 4 реда:
            //•	Бюджетът, с който разполагат – реално число в интервала[1.00 … 10000.00]
            //•	Брой нощувки – цяло число в интервала[0 … 1000]
            //•	Цена за нощувка – реално число в интервала[1.00 … 500.00]
            //•	Процент за допълнителни разходи – цяло число в интервала[0 … 100]
            //Изход
            //Отпечатването на конзолата зависи от резултата:
            //•	Ако сумата е достатъчна:
            //o   "Ivanovi will be left with {останали пари след почивката} leva after vacation."
            //•	Ако НЕ е достигната сумата:
            //            o   "{парите нужни до достигане на целта} leva needed."
            //Сума трябва да се форматира до втората цифра след десетичния знак.
            double budjet = double.Parse(Console.ReadLine());
            int numOvernight = int.Parse(Console.ReadLine());
            double priceOvernight = double.Parse(Console.ReadLine());
            double percentOver = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            double price = 0;

            if (numOvernight > 7)
            {
                price = priceOvernight * 0.95;
                totalPrice = numOvernight * price;
                totalPrice = totalPrice + (budjet * percentOver) / 100;
                
            }
            else
            {
                totalPrice = numOvernight * priceOvernight;
                totalPrice = totalPrice + (budjet * percentOver) / 100;
            }
            if (totalPrice <= budjet)
            {
                double different = budjet - totalPrice;
                Console.WriteLine($"Ivanovi will be left with {different:f2} leva after vacation.");
            }
            else
            {
                double diferent = totalPrice - budjet;
                Console.WriteLine($"{diferent:f2} leva needed.");
            }
            // 8 нощувки > 7, следователно има 5 % отстъпка от цената за нощувка, която е 100лв. 5 % от 100 е 5 лв. -> 100 – 5-> 95 лв.за нощувка след отстъпката,
            // 8 нощувки по 95лв. -> 760 лв.
            //2 % от бюджета е предвиден за допълнителни разходи. 2 % от 800.50 е 16.01 лв.
            //760 + 16.01 = 776.01 <= 800.50, следователно парите са им достатъчни и след почивката се връщат със 800.50 – 776.01 = 24.49 лв.

        }
    }
}
