using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int numPars = width*length;
            while (numPars >0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine($"{numPars} pieces are left.");
                    break;
                }
                int paseCake = int.Parse(input);
                numPars -= paseCake;
            }
            if (numPars <=0)
            {
                Console.WriteLine($"No more cake left! You need {Math .Abs(numPars)} pieces more.");
            }
        }
    }
}
