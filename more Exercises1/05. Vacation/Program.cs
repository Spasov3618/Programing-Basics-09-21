using System;

namespace _05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //•	При бюджет по - голям от 3000лв.:
            //o Настаняване в "Hotel"
            //o Според сезона локацията ще е една от следните и ще струва 90 % от бюджета:
            //	Лято – Аляска
            //	Зима – Мароко
            //Вход
            //Входът се чете от конзолата и се състои от два реда:
            //•	Първи ред – Бюджет – реално число в интервала[10.00...10000.00]
            //•	Втори ред –  Сезон – текст "Summer" или "Winter"
            //Изход
            //На конзолата трябва да се отпечатат един ред.
            //"{локацията} – {мястото за настаняване} – {цената}"
            //Цената трябва да е форматирана до вторият знак след десетичната запетая.
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            
            string location = "";
            string place = "";
            if (season == "Summer")
            {
                location = "Alaska";
            }
            else if (season == "Winter")
            {
                location = "Morocco";
            }
            if (budjet <= 1000)
            {
                place = "Camp";
                switch (season)
                {
                    case "Summer":
                        budjet *= 0.65;
                        break;
                    case "Winter":
                        budjet *= 0.45;
                        break;
                }
            }
            else if (budjet >= 1000 && budjet <= 3000)
            {
                place = "Hut";
                switch (season)
                {
                    case "Summer":
                        budjet *= 0.80;
                        break;
                    case "Winter":
                        budjet *= 0.60;
                        break;
                }
            }
            else if (budjet > 3000)
            {
                place = "Hotel";
                budjet *= 0.90;
            }
            Console.WriteLine($"{location } - {place } - {budjet:f2}");
        }
    }
}
