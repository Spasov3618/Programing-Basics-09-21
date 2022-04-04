using System;

namespace PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Магазин за компютърни игри ви наема за да направите статистика на процента продажби на игрите от последния месец,
            //като изчислите по колко процента от общите продажби са за някоя от игрите.
            //Процентите трябва да бъдат разделени на четири части, три заглавия на игри и всички останали :
            //•	Hearthstone
            //•	Fornite
            //•	Overwatch
            //•	Others
            //Вход
            //От конзолата се четат:
            //•	Брой продадени игри - n - цяло положително число в интервала[1… 100]
            //За следващите n реда се чете по един ред:
            //            o Име на игра -текст
            //Изход
            //На конзолата да се изпишат четири реда:
            //	"Hearthstone - {процент продажби на Hearthstone}%"

            //    "Fornite - {процент продажби на Fornite}%"

            //    "Overwatch - {процент продажби на Overwatch}%"

            //    "Others - {процент продажби на всички останали игри}%"
            //Резултатът да бъде закръглен до втората цифра след десетичния знак.
            double numSale = double.Parse(Console.ReadLine());
            double counterHearthstone = 0;
            double counterFornite = 0;
            double counterOverwatch = 0;
            double counterOthers = 0;
            for (int i = 1; i <= numSale ; i++)
            {
                string nameGame = Console.ReadLine();
                if (nameGame != "Hearthstone" && nameGame!= "Fornite" && nameGame != "Overwatch")
                {
                    counterOthers++;
                }
                switch (nameGame)
                {
                    case "Hearthstone":
                        counterHearthstone++;
                        break;
                    case "Fornite":
                        counterFornite++;
                        break;
                    case "Overwatch":
                        counterOverwatch++;
                        break;
                                      

                }
            }
            double percentHearthstone = counterHearthstone / numSale * 100;
            double percentFornite = counterFornite / numSale * 100;
            double percentOverwatch = counterOverwatch / numSale * 100;
            double percentOthers = counterOthers / numSale * 100;
            Console.WriteLine($"Hearthstone - {percentHearthstone:f2}%");
            Console.WriteLine($"Fornite - {percentFornite:f2}%");
            Console.WriteLine($"Overwatch - {percentOverwatch:f2}%");
            Console.WriteLine($"Others - {percentOthers:f2}%");
        }
    }
}
