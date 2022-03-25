using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {

            //Рибарите ползват допълнително 5 % отстъпка, ако са четен брой освен ако не е есен - тогава нямат допълнителна отстъпка,
            //която се начислява след като се приспадне отстъпката по горните критерии.
            // Напишете програма, която да пресмята дали рибарите ще съберат достатъчно пари. 
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double numberOfFishmen = double.Parse(Console.ReadLine());
            const double rentBordSpring = 3000;
            const double rentBordSummer = 4200;
            const double rentBordAutumn = 4200;
            const double rentBordWinter = 2600;
            double prise = 0;
            if (numberOfFishmen <= 6)
            {
                switch (season)
                {
                    case "Spring":
                        prise -= rentBordSpring * 0.10;
                        prise = rentBordSpring + prise;
                        break;
                    case "Summer":
                        prise -= rentBordSummer * 0.10;
                        prise = rentBordSummer + prise;
                        break;
                    case "Autumn":
                        prise -= rentBordAutumn * 0.10;
                        prise = rentBordAutumn + prise;
                        break;
                    case "Winter":
                        prise -= rentBordWinter * 0.10;
                        prise = rentBordWinter + prise;
                        break;
                }
            }
            else if (numberOfFishmen > 7 && numberOfFishmen <= 11)
            {
                switch (season)
                {
                    case "Spring":
                        prise -= rentBordSpring * 0.15;
                        prise = rentBordSpring + prise;
                        break;
                    case "Summer":
                        prise -= rentBordSummer * 0.15;
                        prise = rentBordSummer + prise;
                        break;
                    case "Autumn":
                        prise -= rentBordAutumn * 0.15;
                        prise = rentBordAutumn + prise;
                        break;
                    case "Winter":
                        prise -= rentBordWinter * 0.15;
                        prise = rentBordWinter + prise;
                        break;
                }
            }
            else if (numberOfFishmen > 12)
            {
                switch (season)
                {
                    case "Spring":
                        prise -= rentBordSpring * 0.25;
                        prise = rentBordSpring + prise;
                        break;
                    case "Summer":
                        prise -= rentBordSummer * 0.25;
                        prise = rentBordSummer + prise;
                        break;
                    case "Autumn":
                        prise -= rentBordAutumn * 0.25;
                        prise = rentBordAutumn + prise;
                        break;
                    case "Winter":
                        prise -= rentBordWinter * 0.25;
                        prise = rentBordWinter + prise;
                        break;
                }
            }
            if (numberOfFishmen % 2 == 0 && season != "Autumn")
            {
                prise -= prise * 0.05;
            }
            if (budjet >= prise)
            {
                double totalPrise = budjet - prise;
                Console.WriteLine($"Yes! You have {totalPrise:f2} leva left.");
            }
            else
            {
                double needMonne = prise - budjet;
                Console.WriteLine($"Not enough money! You need {needMonne:f2} leva.");
            }

        }
    }
}
