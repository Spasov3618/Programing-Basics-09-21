using System;

namespace Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            //Преподавателският екип на СофтУни организира работен ден на басейн по случай настъпването на лятото.
            //Вашата задача е да напишете програма, която да изчислява каква сума трябва да се заплати.
            //За всеки един човек от екипа трябва да се заплати такса вход. Трябва да имате предвид, че един чадър стига за двама души.
            //Знае се, че само 75 % от екипа искат шезлонги.При изчислението на броя на чадърите и шезлонгите, техният брой да се закръгли до по-голямото цяло число.
            //Вход
            //От конзолата се четат 4 числа:
            //1.Първи ред – брой на хората.Цяло число в интервала[1…100]
            //2.Втори ред – такса вход. Реално число в интервала[0.00…50.00]
            //3.Трети ред – цена един за шезлонг. Реално число в интервала[0.00…50.00]
            //4.Четвърти ред – цена за един чадър. Реално число в интервала[0.00...50.00]
            //Изход
            //"{сумата за покриване на разходите} lv."

            double numPeople = double.Parse(Console.ReadLine());
            double priceInput = double.Parse(Console.ReadLine());
            double priceTable = double.Parse(Console.ReadLine());
            double priceUmbrela = double.Parse(Console.ReadLine());
            double total = numPeople * priceInput;
            double umbrela =(Math.Ceiling(numPeople / 2)) * priceUmbrela;
            double table = (Math.Ceiling ( numPeople * 0.75)) * priceTable;
            total += umbrela + table;
            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
