using System;

namespace Series_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която изчислява колко време ще ви отнеме да изгледате всички епизоди на един сериал в минути.
            //Ще разполагате с брой сезони, брой епизоди на сезон и времетраене на един епизод.Във всеки епизод има реклами,
            //които са с продължителност 20 % от времето на един епизод. Също така знаете, че всеки сезон завършва със специален епизод,
            //който е с 10м по-дълъг от обичайното. 
            //Вход
            //От конзолата се четат 4 реда:
            //•	Име на сериал - текст
            //•	Брой сезони – цяло число в диапазона[1… 10]
            //•	Брой епизоди  – цяло число в диапазона[10… 80]
            //•	Времетраене на обикновен епизод без рекламите – реално число в диапазона[40.0… 65.0]
            //Изход
            //Да се отпечата на конзолата времето, необходимо за изглеждане на всички епизоди, закръглено до най-близкото цяло число надолу в следния формат:
            //"Total time needed to watch the {име на сериал} series is {време} minutes."
            string name = Console.ReadLine();
            int numSeson = int.Parse(Console.ReadLine());
            int epizod = int.Parse(Console.ReadLine());
            double minEpizod = double.Parse(Console.ReadLine());
            minEpizod = minEpizod + minEpizod * 0.2;
            double total = (numSeson * 10) + numSeson * epizod * minEpizod;
            Console.WriteLine($"Total time needed to watch the {name} series is {Math.Floor(total)} minutes.");
        }
    }
}
