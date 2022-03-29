using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Един сезон е 4 месеца.Според зависи сезона и броя километри на месец ще му се заплаща различна сума на километър:
            //	                Пролет / Есен           Лято                  Зима
            //км на месец <= 5000          0.75 лв./ км            0.90 лв./ км          1.05 лв./ км
            //5000 < км на месец <= 10000  0.95 лв./ км 1.10 лв./ км 1.25 лв./ км
            //10000 < км на месец <= 20000 1.45 лв./ км – за който и да е сезон
            //текст "Spring", "Summer", "Autumn" или "Winter"
            //След като са извадени 10 % за данъци се отпечатват останалите пари.

            //Изход
            //На конзолата трябва да се отпечатат едно число:
            //•	Заплатата на шофьора след данъците, форматирана до втория знак след десетичната запетая.
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            double total = 0;
            if (km <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                        total = km * 0.75 * 4;
                        break;
                    case "Summer":
                        total = km * 0.90 * 4;
                        break;
                    case "Autumn":
                        total = km * 0.75 * 4;
                        break;
                    case "Winter":
                        total = km * 1.05 * 4;
                        break;
                }
            }
            else if (km > 5000 && km <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                        total = km * 0.95 * 4;
                        break;
                    case "Summer":
                        total = km * 1.10 * 4;
                        break;
                    case "Autumn":
                        total = km * 0.95 * 4;
                        break;
                    case "Winter":
                        total = km * 1.25 * 4;
                        break;
                }
            }
            else if (km > 10000 && km <= 20000)
            {
                switch (season)
                {
                    case "Spring":
                        total = km * 1.45 * 4;
                        break;
                    case "Summer":
                        total = km * 1.45 * 4;
                        break;
                    case "Autumn":
                        total = km * 1.45 * 4;
                        break;
                    case "Winter":
                        total = km * 1.45 * 4;
                        break;
                }
            }
            total *= 0.9;
            Console.WriteLine($"{total:f2}");
        }
    }
}
