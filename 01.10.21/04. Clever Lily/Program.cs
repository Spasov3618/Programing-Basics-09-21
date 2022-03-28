using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int yersOfLili = int.Parse(Console.ReadLine());
            double priceMashine = double.Parse(Console.ReadLine());
            int   priceToy = int.Parse(Console.ReadLine());
           int moneyEvenYears = 0;
            int numToy = 0;
            int totalMoney = 0;

            for (int i = 1; i <= yersOfLili; i++)
            {
                moneyEvenYears += 5;
                if (i % 2 == 0)
                {
                    totalMoney += moneyEvenYears - 1;
                }
                else
                {
                    numToy++;
                }
            }
            totalMoney += numToy * priceToy;
            
           
        if (totalMoney >= priceMashine)
	{
                Console.WriteLine($"Yes! {totalMoney - priceMashine:f2}");
             }
        else
            {
                Console.WriteLine($"No! {priceMashine - totalMoney:f2}");
            }
        }
    }
}
