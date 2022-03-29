using System;

namespace _09._Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            double  wedar =double .Parse (Console.ReadLine());
            //Градуси Време
            //26.00 - 35.00   Hot
            //20.1 - 25.9 Warm
            //15.00 - 20.00   Mild
            //12.00 - 14.9    Cool
            //5.00 - 11.9 Cold
            if (wedar >=26 && wedar <=35)
            {
                Console.WriteLine("Hot");
            }
            else if (wedar >=20.1 && wedar <=25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (wedar >=15 && wedar <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (wedar >=12 && wedar <=14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (wedar >=5 && wedar <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
