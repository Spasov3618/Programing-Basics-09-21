using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            const double dolars = 1.31;
            decimal dollars = pounds * (decimal) dolars;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
