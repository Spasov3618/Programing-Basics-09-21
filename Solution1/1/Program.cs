using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double result = 0;

            if (figure == "sguare")
            {
                double a = double.Parse(Console.ReadLine());
                result = a * a;
            }
            {
                if (figure == "rectangle")
                {
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    result = a * b;
                }
                {
                    if (figure == "circle")

                    {
                        double r = double.Parse(Console.ReadLine());
                        result = r * r * Math.PI;
                    }
                    {
                        if (figure == "triangle")
                        {
                            double a = double.Parse(Console.ReadLine());
                            double ha = double.Parse(Console.ReadLine());

                            result = (a * ha) / 2;
                        }
                        {
                            Console.WriteLine($"{result: f3}");
                        }
    }
}
