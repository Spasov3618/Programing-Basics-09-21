using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger maxsnow = 0;
            int snowballSnowMax = 0;
            int snowballTimeMAx = 0;
            int snowballQualitymax = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime),snowballQuality);
                if (snowballValue >= maxsnow)
                {
                    snowballSnowMax = snowballSnow;
                    snowballTimeMAx = snowballTime;
                    snowballQualitymax = snowballQuality;
                    maxsnow = snowballValue;
                }
            }
            Console.WriteLine($"{snowballSnowMax} : {snowballTimeMAx} = {maxsnow} ({snowballQualitymax})");
        }
    }
}
