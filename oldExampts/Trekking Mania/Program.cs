using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            int numGrups = int.Parse(Console.ReadLine());
            double counterMusala = 0;
            double counterMonblan = 0;
            double counterKilimandjaro = 0;
            double counterK2 = 0;
            double counterEverest = 0;
            double totalPeople = 0;
            for (int i = 1; i <= numGrups; i++)
            {
                int numPeople = int.Parse(Console.ReadLine());
                if (numPeople <=5)
                {
                    counterMusala += numPeople;
                   
                }
                else if (numPeople >=6 && numPeople <=12)
                {
                    counterMonblan += numPeople;
                }
                else if (numPeople >=13 && numPeople <=25)
                {
                    counterKilimandjaro += numPeople;
                }
                else if (numPeople >=26&& numPeople<=40)
                {
                    counterK2 += numPeople;
                }
                else if (numPeople >=41)
                {
                    counterEverest += numPeople;
                }
            }
            totalPeople = counterEverest + counterK2 + counterKilimandjaro + counterMonblan + counterMusala;
            double percentMusala = counterMusala / totalPeople * 100;
            double percentMonbat = counterMonblan / totalPeople * 100;
            double percentKilimandj = counterKilimandjaro/ totalPeople*100;
            double percentK2 = counterK2 / totalPeople * 100;
            double percentEverest = counterEverest / totalPeople * 100;
            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMonbat:f2}%");
            Console.WriteLine($"{percentKilimandj:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");
            //Изход
            //Да се отпечатат на конзолата 5 реда, всеки от които съдържа процент между 0.00 % и 100.00 % с
            //точност до втората цифра след десетичната запетая.
            //•	Първи ред -процентът изкачващи Мусала
            //•	Втори ред – процентът изкачващи Монблан
            //•	Трети ред – процентът изкачващи Килиманджаро
            //•	Четвърти ред – процентът изкачващи К2
            //•	Пети ред – процентът изкачващи Еверест
        }
    }
}
