using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * a:f3}");
            }

            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * b:f3}");
            }

            else if (figure == "circle")

            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"{r * r * Math.PI:f3}");
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(a * ha) / 2:f3}");
            }
            }
    }
}