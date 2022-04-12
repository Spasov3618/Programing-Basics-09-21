using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double capacitet = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling(people/capacitet));
        }
    }
}
