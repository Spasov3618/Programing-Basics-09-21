using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ocenka = double.Parse(Console.ReadLine());
            if (ocenka >= 5.5) 
            Console.WriteLine("Excellent!");
        }
    }
}
