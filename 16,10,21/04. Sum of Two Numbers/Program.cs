using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int majikNum = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int a = start; a <= end; a++)
            {
                for (int b = start ; b <= end; b++)
                {
                    counter++;
                    if (a + b == majikNum)

                    {
                        Console.WriteLine($"Combination N:{counter} ({a} + {b} = {majikNum})");
                        return;

                    }
                   
                        
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {majikNum}");
        }
    }
}
