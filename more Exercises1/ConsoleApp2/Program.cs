using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Да се отпечата на конзолата едно число:
            //"{дарената сума}" - форматирана с точност до 2 знака след десетичната запетая.
            double numJuniors = double.Parse(Console.ReadLine());
            double numSeniors = double.Parse(Console.ReadLine());
            string trase = Console.ReadLine();
            double moyneJuniors = 0;
            double moyneSeniors = 0;
            double money = 0;
            switch (trase )
            {
                case "trail":
                    moyneJuniors = numJuniors * 5.50;
                    moyneSeniors = numSeniors * 7;
                    break;
                case "cross-country":
                    moyneJuniors = numJuniors * 8;
                    moyneSeniors = numSeniors * 9.50;
                    if ((numSeniors + numJuniors ) >=50)
                    {
                        moyneJuniors *= 0.75;
                        moyneSeniors *= 0.75;
                    }
                    break;
                case "downhill":
                    moyneJuniors = numJuniors * 12.25;
                    moyneSeniors = numSeniors * 13.75;
                    break;
                case "road":
                    moyneJuniors = numJuniors * 20.00;
                    moyneSeniors = numSeniors * 21.50;
                    break;
            }
            money = moyneJuniors + moyneSeniors;
            money *= 0.95;
            Console.WriteLine($"{money:f2}");
        }

    }
}