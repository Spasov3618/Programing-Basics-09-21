using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            const double  premierPrice = 12;
            const double normalPrise = 7.50;
            const double  discauntPrice = 5;

            string type = Console.ReadLine();
            int col = int.Parse(Console.ReadLine());
            int roll = int.Parse(Console.ReadLine());
            double totalMonne = 0;
            switch  (type)
                {
                case "Premiere":
                    totalMonne = col * roll * premierPrice;
                    break;
                case "Normal":
                    totalMonne = col * roll * normalPrise;
                    break;
                case "Discount":
                    totalMonne = col * roll * discauntPrice;
                    break;
            }
            Console.WriteLine($"{totalMonne:f2} leva");
        }
    }
}
