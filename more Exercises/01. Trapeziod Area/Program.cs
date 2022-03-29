using System;

namespace _01._Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
                     
            double priceVegetabals = double.Parse(Console.ReadLine());
            double priceFruit = double.Parse(Console.ReadLine());
            double kiloVegetabals = double.Parse(Console.ReadLine());
            double kiloFruit = double.Parse(Console.ReadLine());
            double totalMoney = (priceVegetabals * kiloVegetabals) + (priceFruit * kiloFruit) ;
            double total = totalMoney / 1.94;
            Console.WriteLine($"{total:f2}");
            //Изход
            //Да се отпечата на конзолата едно число: приходите от всички плодове и зеленчуци в евро.
            //Резултата да се форматира до втория знак след десетичния разделител.

        }
    }
}
