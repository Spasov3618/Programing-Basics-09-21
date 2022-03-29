using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
                                
            //Изход
            //На конзолата трябва да се отпечатат два реда.
            //•	Първи ред – "{Вид на класа}"
            //o   "Economy class", "Compact class" или "Luxury class"
            //•	Втори ред – "{Вид на колата} - {цена на колата}"
            //o Видът на колата – "Cabrio" или "Jeep"
            //o Цената трябва да е форматирана до втория знак след запетаята
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string car = "";
            string klass = "";
            if (budjet <= 100)
            {
                klass = "Economy class";
                switch (season)
                {
                    case "Summer":
                        car = "Cabrio";
                        budjet *= 0.35;
                        break;
                    case "Winter":
                        car = "Jeep";
                        budjet *= 0.65;
                        break;
                }
            }
            else if (budjet > 100 && budjet <= 500)
            {
                klass = "Compact class";
                switch (season)
                {
                    case "Summer":
                        car = "Cabrio";
                        budjet *= 0.45;
                        break;
                    case "Winter":
                        car = "Jeep";
                        budjet *= 0.80;
                        break;
                }
            }
            else
            {
                klass = "Luxury class";
                switch (season)
                {
                    case "Summer":
                        car = "Jeep";
                        budjet *= 0.90;
                        break;
                    case "Winter":
                        car = "Jeep";
                        budjet *= 0.90;
                        break;
                }
            }
            Console.WriteLine(klass);
            Console.WriteLine($"{car} - {budjet:f2}");

        }
    }
}
