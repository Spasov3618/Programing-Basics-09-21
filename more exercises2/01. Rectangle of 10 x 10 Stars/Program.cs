using System;

namespace _01.UniquePINCodes 
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            for (int i = 2; i <= firstNum; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 2; j <= secondNum; j++)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {
                            for (int k = 2; k <= thirdNum; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    Console.WriteLine($"{i} {j} {k}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
