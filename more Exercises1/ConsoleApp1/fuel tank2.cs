using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double benzin = 2.22;
            const double dizel = 2.33;
            const double gas = 0.93;

            double prisebenin = 0;
            double prisedizel = 0;
            double prisegas = 0;


            string fuel = Console.ReadLine();
            double kolichestvo = double.Parse(Console.ReadLine());
            string kard = Console.ReadLine();
            if (kard == "Yes")
            {
                prisebenin = benzin - 0.18;
                prisedizel = dizel - 0.12;
                prisegas = gas - 0.08;
            }
            else if (kard == "No")
            {
                prisebenin = benzin;
                prisedizel = dizel;
                prisegas = gas;
            }
                double total = kolichestvo * prisebenin;
                double totalDizel = kolichestvo * prisedizel;
                double totalGas = kolichestvo * prisegas;

            
            if (kolichestvo >= 20 && kolichestvo <= 25)
            {
                total  *= 0.92;
                totalDizel  *= 0.92;
                totalGas  *= 0.92;
            }
            else if (kolichestvo > 25)
            {
                total *= 0.9;
                totalDizel *= 0.9;
                totalGas *= 0.9;
            }

            if (fuel == "Gasoline")
            {
                Console.WriteLine($"{total:f2} lv.");

            }
            else if (fuel == "Diesel")
            {
                Console.WriteLine($"{totalDizel:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{totalGas:f2} lv.");
            }

            //Горивото е газ, цена за литър газ е 0.93 лв.
            //Шофьора има карта за отстъпки, отстъпката за газ е 8ст.от цената за литър. Цената на която той ще зареди е 0.93 – 0.08 = 0.85 ст.
            //30 литра по 0.85 е 25.5 лв.но тъй като при заредени повече от 25 литра има отстъпка.
            //25.5 – 10 % = 22.95 лв.крайна цена

        }
    }
}
