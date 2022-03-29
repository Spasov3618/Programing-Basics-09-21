using System;

namespace _01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {

            int bottlesDetergent = int.Parse(Console.ReadLine());

            double mlDetergent = bottlesDetergent * 750;
            double plateDetergent = 5;
            double potDetergent = 15;

            int potCounter = 0;
            int plateCounter = 0;

            int dishesCounter = 0;

            while (mlDetergent >= 0)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine("Detergent was enough!");
                    Console.WriteLine($"{plateCounter} dishes and {potCounter} pots were washed.");
                    Console.WriteLine($"Leftover detergent {mlDetergent} ml.");
                    break;
                }
                else
                {
                    int dishes = int.Parse(input);
                    dishesCounter++;

                    if (dishesCounter % 3 == 0)
                    {
                        mlDetergent -= dishes * potDetergent;
                        potCounter += dishes;
                    }
                    else
                    {
                        mlDetergent -= dishes * plateDetergent;
                        plateCounter += dishes;
                    }

                }
            }
            if (mlDetergent < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(mlDetergent)} ml. more necessary!");
            }

        }
    }
}