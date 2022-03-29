using System;

namespace _05._Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i <num; i++)
            { 
                double input = double.Parse(Console.ReadLine());
                total += input;
            }
            double average = total / num;
            Console.WriteLine($"{average:f2}");
        }
    }
}
