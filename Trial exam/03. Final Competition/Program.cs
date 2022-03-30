using System;

namespace _03._Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //            На конзолата се отпечатват 2 реда:
            //•	Сумата, която са дали за благотворителност
            //"Charity - {сума за благотворителност}"
            //•	Сумата, която е получил всеки танцьор
            //"Money per dancer - {сума за танцьор}"
            //Сумите да бъдат форматирани до втория знак след десетичната запетая.
            int numSport = int.Parse(Console.ReadLine());
            double  numPoints = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double totalPoints = numSport * numPoints;
            double money = 0;
            switch (place)
            {
                case "Bulgaria":
                    if (season== "summer")
                    {
                        money = totalPoints *0.95;
                    }
                    else if (season == "winter")
                    {
                       
                        money =totalPoints * 0.92;
                    }
                    break;
                case "Abroad":
                    if (season == "summer")
                    {
                        money = totalPoints +(totalPoints *0.5);
                        money *= 0.90;
                    }
                    else if (season == "winter")
                    {
                        money = totalPoints + (totalPoints * 0.5);
                        money *= 0.85;
                    }
                    break;
            }
            double charity = money * 0.75;
            double diferent = money - charity;
            double moneySports = diferent / numSport;
            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneySports:f2}");
        }
    }
}
