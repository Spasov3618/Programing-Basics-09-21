using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double hHouse = double.Parse(Console.ReadLine());
            double ystena = double.Parse(Console.ReadLine());
            double hRoof = double.Parse(Console.ReadLine());
            double stena = 2 * (hHouse * ystena) - (2 * 2.25);
            double stena1 = 2 * (hHouse * hHouse) - 2.4;
            double totalGreen = (stena + stena1) / 3.4;
            double roof = 2 * (hHouse * ystena) + 2 * (hHouse * hRoof / 2);
            double totalRed = roof / 4.3;
            Console.WriteLine($"{totalGreen :f2}");
            Console.WriteLine($"{totalRed :f2}");
        }
    }
}
