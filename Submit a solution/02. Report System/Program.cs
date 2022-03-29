using System;

namespace _02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            //•	Ако сумата на всички закупени продукти надвиши или достигне очакваната сума, програмата трябва да приключи и на конзолата
            //да се изпишат два реда:
            // "Average CS: {средно плащане в кеш на човек}"
            // "Average CC: {средно плащане с карта на човек}"
            //              Плащанията трябва да бъдат форматирани до втората цифра след десетичния знак.
            
            // По условие се редуват първо в брой плащане, след това чрез кредитна карта
            //120 >= 100 транзакцията се отхвърля 8 <= 10 транзакцията се отхвърля 63 <= 100 => транзакцията е успешна. 256 >= 10 => транзакцията е успешна. 
            //78 <= 100 =>  транзакцията е успешна. 317 >= 10 => транзакцията е успешна.Обща събрана сума => 63 + 256 + 78 + 317 = 714; 714 >= 500 =>
            //Обща сума в брой => 63 + 78 = 141 Средно в брой => 141 / 2 = 70.50 Общо кредитни карти => 256 + 317 = 573
            //Средно кредитни карти => 573 / 2 = 286.50
            double total = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            double numTranzakshan = 0;
            double numKesh = 0;
            double numBank = 0;
            double priceKesh = 0;
            double prceBank = 0;
            while (totalPrice < total)
            {
            string input = Console.ReadLine();
                numTranzakshan++;
                if (input == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }
                double price = double.Parse(input);
                if (numTranzakshan % 2 == 0)
                {
                    if (price  < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }

                    else
                    {
                        Console.WriteLine("Product sold!");
                        numBank++;
                        prceBank += price;
                        totalPrice += price;

                    }
                }
                else
                {
                    if (price > 100)
                        Console.WriteLine("Error in transaction!");
                    else
                    {
                        Console.WriteLine("Product sold!");
                        numKesh++;
                        priceKesh += price;
                        totalPrice += price;
                    }
                }
                if (totalPrice >= total )
                {
                    double averageKesh = priceKesh / numKesh;
                    double averageBank = prceBank / numBank;
                    Console.WriteLine($"Average CS: {averageKesh:f2}");
                    Console.WriteLine($"Average CC: {averageBank:f2}");
                }
            }
        }
    }
}
