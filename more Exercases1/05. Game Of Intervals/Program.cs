using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int num = int.Parse(Console.ReadLine());
            double total = 0;
            int points0 = 0;
            int points1 = 0;
            int points2 = 0;
            int points3 = 0;
            int points4 = 0;
            int invalidPoints = 0;

            for (int i = 0; i < num; i++)
            {
                int result = int.Parse(Console.ReadLine());
                if (result>=0 && result<10)
                {
                    points0++;
                    total += result * 0.2;
                }
                else if (result >= 10 && result < 20)
                {
                    points1++;
                    total += result * 0.3;
                }
                else if (result >= 20 && result < 30)
                {
                    points2++;
                    total += result * 0.4;
                }
                else if (result >= 30 && result < 40)
                {
                    points3++;
                    total += 50;
                }
                else if (result >= 40 && result <= 50)
                {
                    points4++;
                    total += 100;
                }
                else
                {
                    invalidPoints++;
                    total /= 2;
                }

            }
            double percent0 = 1.0*points0 / num *100;
            double percent1 = 1.0*points1 / num*100;
            double percent2 = 1.0*points2 / num*100;
            double percent3 = 1.0*points3 / num*100;
            double percent4 = 1.0*points4 / num*100;
            double percentInvalid = 1.0 * invalidPoints / num * 100;
            Console.WriteLine($"{total:f2}");
            Console.WriteLine($"From 0 to 9: {percent0:f2}%");
            Console.WriteLine($"From 10 to 19: {percent1:f2}%");
            Console.WriteLine($"From 20 to 29: {percent2:f2}%");
            Console.WriteLine($"From 30 to 39: {percent3:f2}%");
            Console.WriteLine($"From 40 to 50: {percent4:f2}%");
            Console.WriteLine($"Invalid numbers: {percentInvalid:f2}%");
           

        }
    }
}
