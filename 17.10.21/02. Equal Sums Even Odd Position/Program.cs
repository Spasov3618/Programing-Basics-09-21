using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            for (int i = firstNum; i <= secondNum; i++)
            {
                string curentNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int j = 0; j < curentNum.Length; j++)
                {
                    int curentDigit = int.Parse(curentNum [j].ToString());
                    if (j%2==0)
                    {
                        evenSum += curentDigit;
                    }
                    else
                    {
                        oddSum += curentDigit;
                    }
                }
                if (oddSum == evenSum )
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
