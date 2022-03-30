using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            //            От конзолата се четат поредица от числа, всяко на отделен ред:
            //1.Капацитетът на стадиона – цяло число в интервала[1 … 10000];
            //            2.Броят на всички фенове – цяло число в интервала[1 … 10000].
            //За всеки един фен, на отделен ред се прочита:
            //1.Секторът, на който се намира – текст – "A", "B", "V" и "G".
            //Изход
            //Да се отпечатат на конзолата 5 реда, всеки от които съдържа процент между 0.00 % и 100.00 %,
            //форматирани до втората цифра след десетичната запетая:
            //1.Процентът на феновете в сектор А
            //2.Процентът на феновете в сектор Б
            //3.Процентът на феновете в сектор В
            //4.Процентът на феновете в сектор Г
            //5.Процентът на всички фенове, спрямо капацитета на стадиона.
            int stadion = int.Parse(Console.ReadLine());
            int numFens = int.Parse(Console.ReadLine());
            int counterA = 0;
            int counterB = 0;
            int counterV = 0;
            int counterG = 0;
            for (int i = 0; i < numFens; i++)
            {
                string sector = Console.ReadLine();
                switch (sector)
                {
                    case "A":
                        counterA++;    
                        break;
                    case "B":
                        counterB++;
                        break;
                    case "V":
                        counterV++;
                        break;
                    case "G":
                        counterG++;
                        break;
                }
            }
            double percentA = 1.0 * counterA / numFens * 100;
            double percentB = 1.0 * counterB / numFens * 100;
            double percentV = 1.0 * counterV / numFens * 100;
            double percentG = 1.0 * counterG / numFens * 100;
            double percentAll = 1.0 * numFens/stadion * 100;
            Console.WriteLine($"{percentA:f2}%");
            Console.WriteLine($"{percentB:f2}%");
            Console.WriteLine($"{percentV:f2}%");
            Console.WriteLine($"{percentG:f2}%");
            Console.WriteLine($"{percentAll:f2}%");
        }
    }
}
