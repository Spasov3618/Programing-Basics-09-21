using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int majicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = start; i <= finish; i++)
            {
                for (int j = start; j <= finish; j++)
                {
                counter++;
                    int c = i + j;
                    if (c== majicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {majicNum})");
                        return;
                    }

                }

            }
                Console.WriteLine($"{counter} combinations - neither equals {majicNum}");
        }
    }
}
