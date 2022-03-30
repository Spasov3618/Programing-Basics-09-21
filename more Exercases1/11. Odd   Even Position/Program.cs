using System;

namespace _11._Odd___Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {

            double oddSum = 0;
            double evenSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    double NumberEven = double.Parse(Console.ReadLine());
                    evenSum += NumberEven;

                    if (NumberEven < evenMin)
                    {
                        evenMin = NumberEven;
                    }
                    if (NumberEven > evenMax)
                    {
                        evenMax = NumberEven;
                    }
                }
                else
                {
                    double NumberOdd = double.Parse(Console.ReadLine());
                    oddSum += NumberOdd;
                    if (NumberOdd < oddMin)
                    {
                        oddMin = NumberOdd;
                    }
                    if (NumberOdd > oddMax)
                    {
                        oddMax = NumberOdd;
                    }

                }
            }
       
            if (num == 0)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if ((evenMin == double.MaxValue) || (evenMax == Double.MinValue))
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }

            }
    }
}
