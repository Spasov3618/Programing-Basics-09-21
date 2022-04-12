using System;

namespace Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която получава число – n и отпечатва триъгълник от 1 до n, както е в примерите.
            //Ограничения
            //• n ще бъде в интервала[1...20].
            //5   1
            //    2 2
            //    3 3 3
            //    4 4 4 4
            //    5 5 5 5 5
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
            for (int j = 1; j <= i; j++)
                Console.Write(i+" ");
            Console.WriteLine();
            }
            {

            }
        }
    }
}
