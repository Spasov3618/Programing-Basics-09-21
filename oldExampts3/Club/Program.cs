using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double profit = double.Parse(Console.ReadLine());
            double total = 0;
            double sum = 0;
            string coctels = Console.ReadLine();
            while (coctels != "Party!")
            {
                double numCoctels = double.Parse(Console.ReadLine());
                double priceCoctels = coctels.Length;
                sum  += numCoctels * priceCoctels;
               if (sum  % 2 != 0)
                {
                    sum *= 0.75;
                }
                total += sum;
                sum = 0;

                if (total >= profit )
                {
                    Console.WriteLine("Target acquired.");
                    Console.WriteLine($"Club income - {total:f2} leva.");
                    break;
                }

                coctels = Console.ReadLine();
            }
            if (coctels == "Party!")
            {
            double differents = profit - total;
            Console.WriteLine($"We need {differents:f2} leva more.");
                Console.WriteLine($"Club income - {total:f2} leva.");

            }
        }
    }
}
