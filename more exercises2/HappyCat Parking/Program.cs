using System;

namespace HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
                     
            //За всеки четен ден и нечетен час, паркингът таксува 2.50 лева.Във всеки нечетен ден и четен час таксата е 1.25 лева,
            //във всички останали случаи се заплаща 1 лев.Таксуването става на всеки изминал час от деня.
            //Всеки един от изходите трябва да бъде закръглен до втория знак след десетичната запетая.
            int day = int.Parse(Console.ReadLine());
            int numHours = int.Parse(Console.ReadLine());
            double sum = 0;
            double ollSum = 0;
            
            for (int i = 1; i <=day ; i++)
            {
                for (int j = 1; j <= numHours; j++)
                {
                    if (i%2==0 && j%2!=0)
                    {
                        sum += 2.5;
                    }
                    else if (i%2!=0 && j%2==0)
                    {
                        sum += 1.25;
                    }
                    else
                    {
                        sum += 1;
                    }
                }
                    Console.WriteLine($"Day: {i} - {sum:f2} leva");
                ollSum += sum;
                sum = 0;
            }
                    Console.WriteLine($"Total: {ollSum:f2} leva");
        }
    }
}
