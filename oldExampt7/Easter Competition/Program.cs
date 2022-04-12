using System;

namespace Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            //С наближаването на Великден, пекарна организира конкурс за направата на най-хубав козунак.Напишете програма, която да намира сладкаря с най - висок резултат.В началото на конкурса се въвежда броя на козунаците, които ще бъдат дегустирани от посетителите на пекарната, като за всеки козунак различен брой посетители, ще дадат оценка от 1 до 10.
            //Вход
            //Първоначално от конзолата се прочита броя на козунаците – цяло число в интервала[1… 100]
            //След това за всеки козунак се прочита:
            //•	Името на пекаря, който е направил козунака – текст
            //•	До получаване на командата "Stop" се прочита
            //o оценка за козунак от един човек  – цяло число в интервала[1... 10]
            //Изход
            //След получаване на командата "Stop" се печата един ред:
            //•	"{името на пекаря} has {общият брой получени точки} points."
            //Ако след командата "Stop", пекарят е с най-много точки до момента, да се отпечата допълнителен ред:
            //•	"{името на пекаря} is the new number 1!"
            //След дегустация на всички козунаци, да се отпечата един ред:
            //•	"{името на пекаря с най-много точки} won competition with {точките на пекаря} points!"
            int numBread = int.Parse(Console.ReadLine());
            double counterMax = 0;
            string shef = "";
            for (int i = 0; i < numBread ; i++)
            {
                string nameShef = Console.ReadLine();
                double counternow = 0;
                string evaluation = Console.ReadLine();
                while (evaluation!="Stop")
                {
                    double input = double.Parse(evaluation);
                    counternow += input;
                    evaluation = Console.ReadLine();
                }
                if (evaluation=="Stop")
                {
                    Console.WriteLine($"{nameShef} has {counternow} points.");
                    if (counternow>counterMax)
                    {
                        Console.WriteLine($"{nameShef} is the new number 1!");
                    }
                if (counternow>counterMax)
                {
                    counterMax = counternow;
                    shef = nameShef;
                }
                }

            }
            Console.WriteLine($"{shef} won competition with {counterMax} points!");
        }
    }
}
