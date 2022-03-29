using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double  w = double .Parse(Console.ReadLine());
            double  h = double .Parse(Console.ReadLine());
            double numh = h * 100;
            double totalh = Math .Floor ((numh - 100) / 70);
            double numw = w * 100;
            double totalw = Math.Floor((numw / 120));
            double total = totalh * totalw - 3;
            Console.WriteLine(total );
        }
    }
}
