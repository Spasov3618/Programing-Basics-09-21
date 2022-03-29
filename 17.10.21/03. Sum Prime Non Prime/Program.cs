using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int prime = 0;
            int nonPrime = 0;
            while (num != "stop")
            {
                int input = int.Parse(num);
                if (input < 0)
                {
                    Console.WriteLine("Number is negative.");

                }
                else
                {

                    int countner = 0;


                    for (int i = 1; i <= input; i++)
                        if (input % i == 0)
                        {
                            countner++;
                        }

                    if (countner == 2)
                    {
                        prime += input;
                    }
                    else
                    {
                        nonPrime += input;
                    }
                }
                num = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrime}");
        }
    }
}
