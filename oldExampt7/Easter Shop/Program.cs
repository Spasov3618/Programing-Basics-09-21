using System;

namespace Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Покрай великденските празници, квартален магазин започва да продава боядисани яйца.Вашата задача е да напишете програма, която да изчислява колко яйца са продадени, като знаете началната им бройка в магазина. По време на продажбата е възможно да бъдат доставени допълнителни бройки яйца. Ако в даден момент от изпълнението на програмата, клиент поиска да купи повече, отколкото има в наличност, или се получи команда "Close", програмата трябва да приключи изпълнение.
            //Вход
            //От конзолата се чете:
            //•	На първи ред - Началното количество яйца в магазина -цяло число в интервала[1… 10000]
            //•	След това поредица от два реда(до получаване на команда "Close" или при заявка за купуване на повече от наличните в магазина яйца) :
            //o Команда за купуване или допълване на яйца в магазина – текст("Buy" или "Fill")
            //o Брой на яйца, които да бъдат купени или допълнени в магазина – цяло число в интервала
            //[1… 1000]
            //Изход
            //На конзолата да се отпечатат два реда според случая:
            //•	При получаване на командата "Close":
            //o   "Store is closed!"
            //o   "{броя на продадените общо яйца} eggs sold."
            //•	При заявка за покупка на повече яйца, отколкото има в магазина:
            //o   "Not enough eggs in store!"
            //o   "You can buy only {броя на останалите в магазина яйца}."
            int numEggs = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int counterEggs = numEggs;
            int counterEggsBuy = 0;
            while (input!= "Close")
            {
                int num = int.Parse(Console.ReadLine());
                if (input=="Fill")
                {
                    counterEggs += num;
                }
                if (num>counterEggs)
                {
                    Console.WriteLine("Not enough eggs in store!");
                    Console.WriteLine($"You can buy only {counterEggs}.");
                    return;
                }
                if (input=="Buy")
                {
                    counterEggs-=num;
                    counterEggsBuy += num;
                }
                input = Console.ReadLine();
            }
            if (input=="Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{counterEggsBuy} eggs sold.");

            }
        }
    }
}
