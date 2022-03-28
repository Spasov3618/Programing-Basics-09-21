using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която пресмята колко
            //    общо пари има в сметката, след като направите определен брой вноски. На всеки ред ще получавате сумата,
            //    която трябва да внесете в сметката, до получаване на команда "NoMoreMoney".При всяка получена сума на конзолата
            //    трябва да се извежда "Increase: " + сумата и тя да се прибавя в сметката.Ако получите число по-малко от 0 на конзолата
            //    трябва да се изведе "Invalid operation!" и програмата да приключи. Когато програмата
            //    приключи трябва да се принтира "Total: " + общата сума в сметката форматирана до втория знак след десетичната запетая. 
            string   money = (Console.ReadLine());
            double total = 0;
            while (money != "NoMoreMoney")
            {
                double nowMoney = double.Parse(money);
                if (nowMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += nowMoney;
                Console.WriteLine($"Increase: {nowMoney:f2}");
                money = (Console.ReadLine());
            }
                Console.WriteLine($"Total: {total:f2}");
            
        }
    }
}
