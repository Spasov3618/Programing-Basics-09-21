using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            for (int i = 0; i <=num1 ; i++)
            {
                for (int j = 0; j <= num2; j++)
                {
                    for (int k = 0; k <= num3; k++)
                    {
                        if (i*1+j*2+k*5==sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
