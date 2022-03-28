using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Според отворения сайт в таба се налагат следните глоби:
            //•	"Facebook"-> 150 лв.
            //•	"Instagram"-> 100 лв.
            //•	"Reddit"-> 50 лв.
            //От конзолата се четат два реда:
            //След това n – на брой пъти се чете име на уебсайт – текст
            //Изход
            //•	Ако по време на проверката заплатата стане по-малка или равна на 0 лева, на конзолата се изписва
            //"You have lost your salary." и програмата приключва.
            //•	В противен случай след проверката на конзолата се изписва остатъкът от заплатата(да се изпише като цяло число).
            int tab = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < tab; i++)
            {
                string tabb = Console.ReadLine();
                if (tabb == "Facebook")
                {
                    total += 150;
                }
                else if (tabb == "Instagram")
                {
                    total += 100;
                }
                else if (tabb == "Reddit")
                {
                    total += 50;
                }
                else
                {
                    total += 0;
                }
            }

                double totalMoney = salary - total;

                if (salary <= total)
                {
                    Console.WriteLine("You have lost your salary.");
                }
                else
                {
                    Console.WriteLine(totalMoney);
                }
            
        }

    }
}
