using System;

namespace Birthday_Party
{
    class Program
    {
        static void Main(string[] args)
        {
          

            double rent = double.Parse(Console.ReadLine());
            double keik = rent * 0.2;
            double drinks = keik * 0.55;
            double anime = rent / 3;
            double cost = rent + keik + drinks + anime;
            Console.WriteLine($"{cost:f2}");
        }

    }
}
