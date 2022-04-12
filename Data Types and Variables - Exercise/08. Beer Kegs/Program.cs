using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double obem = 0;
            string name = "";
            for (int i = 0; i <n; i++)
            {
                string nameKeg = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                obem = Math.PI * (Math.Pow (r,2)) * h;
                if (obem>sum)
                {
                    sum = obem;
                    name = nameKeg;
                }
            }
            Console.WriteLine(name);
        }
    }
}
