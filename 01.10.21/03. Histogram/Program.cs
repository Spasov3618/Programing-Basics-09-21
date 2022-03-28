using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            for (int i = 0; i < num; i++)
            {
                int curentNum = int.Parse(Console.ReadLine());
                if (curentNum < 200)
                {
                    p1++;
                }
                else if (curentNum >= 200 && curentNum <= 399)
                {
                    p2++;
                }
                else if (curentNum >= 400 && curentNum <= 599)
                {
                    p3++;
                }
                else if (curentNum >= 600 && curentNum <= 799)
                {
                    p4++;
                }
                else if (curentNum >= 800)
                {
                    p5++;
                }
            }
            double percent1 = 1.0 * p1 / num * 100;
            double percent2 = 1.0 * p2 / num * 100;
            double percent3 = 1.0 * p3 / num * 100;
            double percent4 = 1.0 * p4 / num * 100;
            double percent5 = 1.0 * p5 / num * 100;
            Console.WriteLine($"{percent1:f2}%");
            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
            Console.WriteLine($"{percent4:f2}%");
            Console.WriteLine($"{percent5:f2}%");
        }
           
    }
}
