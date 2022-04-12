using System;

namespace Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());
            double price = 0;
            switch (destination)
            {
                case "Large":
                    switch (dates)
                    {
                        case "Red":
                            price = numNights * 16;
                            break;
                        case "Green":
                            price = numNights * 12;
                            break;
                        case "Yellow":
                            price = numNights * 9;
                            break;
                    }
                    break;
               


                case "Medium":
                    switch (dates)
                    {
                        case "Red":
                            price = numNights * 13;
                            break;
                        case "Green":
                            price = numNights * 9;
                            break;
                        case "Yellow":
                            price = numNights * 7;
                            break;
                    }
                    break;
                case "Small":
                    switch (dates)
                    {
                        case "Red":
                            price = numNights * 9;
                            break;
                        case "Green":
                            price = numNights * 8;
                            break;
                        case "Yellow":
                            price = numNights * 5;
                            break;
                    }
                    break;
            }
            price *= 0.65;
            Console.WriteLine($"{price:f2} leva.");
        }
    }
}
