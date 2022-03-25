using System;

namespace _26._09._21
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number >= -100 && number <= 100 && number != 0)
                Console.WriteLine("Yes");


            else
                Console.WriteLine("No");


        }
    }
}
