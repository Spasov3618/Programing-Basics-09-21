using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOne = 0;
            int sumTwo = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sumOne += num;
            }
            {
                for (int i = 1; i <= n; i++)
                {
                    int numTwo = int.Parse(Console.ReadLine());
                    sumTwo += numTwo;
                }
            }
            
            if (sumOne == sumTwo)
            {
                Console.WriteLine(" Yes, sum = " + sumOne );
            }
            else
            {
                int different = Math.Abs(sumOne - sumTwo);
                Console.WriteLine(" No, diff = " + different);
            }
        }       
    }
}
