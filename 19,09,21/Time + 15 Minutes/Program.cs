using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minets = int.Parse(Console.ReadLine());
            minets += 15;
            if (minets >= 60)
            {
                minets -= 60;
                hours += 1;
            }
            if (hours >= 24)
            {
                hours = 0; 
            }
            Console.WriteLine($"{hours}:{minets:d2}");

        }
    }
}
