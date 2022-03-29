using System;

namespace _09._Numbers_from_1_to_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която да умножава положителни числа по 2.
            //От конзолата се четат поредица от реални числа, всяко на нов ред, докато не се въведе отрицателно. 
            //След всяко умножено число на нов ред да се отпечата "Result: {резултата от умножението}".
            //Резултата от умножението да бъде форматиран до втория знак след десетичния разделител.
            // При получаване на негативно число, на конзолата да се отпечата "Negative number!" и програмата да приключи изпълнение.
            double  num =double.Parse ( Console.ReadLine());
            while (num>=0)
            {
                num *= 2;
                Console.WriteLine($"Result: {num:f2}");
                num = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative number!");
        }
    }
}
