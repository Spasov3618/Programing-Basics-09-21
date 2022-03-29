using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFloors = int.Parse(Console.ReadLine());
            int numRooms = int.Parse(Console.ReadLine());
            for (int floors = numFloors ; floors >= 1; floors--)
            {
                for (int rooms = 0; rooms < numRooms; rooms++)
                {
                    if (floors == numFloors )
                    {
                        Console.Write($"L{floors}{rooms} ");
                        continue;
                    }
                    if (floors % 2 == 0)
                    {
                        Console.Write($"O{floors}{rooms} ");
                    }
                    else
                    {
                        Console.Write($"A{floors}{rooms} ");
                    }
                }
            Console.WriteLine();
            }
        }
    }
}
