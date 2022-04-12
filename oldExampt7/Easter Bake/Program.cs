using System;

namespace Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Предстои Великден и Деси е решила да изпече домашни козунаци за колегите си.Главните продукти, които ще трябват на Деси са: брашно и захар.Един пакет захар е 950 грама, а един пакет брашно е 750 грама.Напишете програма, която изчислява колко пакета захар и брашно трябва да купи Деси, за да й стигнат за направата на козунаците, като знаете за всеки един козунак по колко грама захар и брашно са изразходени. Също намерете кое е най - голямото количество захар и брашно, които са използвани.
            //Вход
            //От конзолата се чете 1 ред:
            //•	 Броят на козунаците – цяло число в интервала[1... 100]
            //За всеки козунак се чете:
            //            o Количество изразходвана захар(грамове) – цяло число в интервала[1 … 10000]
            //o Количество изразходвано брашно(грамове) – цяло число в интервала[1 … 10000]
            //Изход
            //Да се отпечатат на конзолата 3 реда:
            //•	"Sugar: {брой нужни пакети захар}"
            //•	"Flour: {брой нужни пакет брашно}"
            //•	"Max used flour is {максимално количество грамове брашно, използвани за правенето на козунак} grams, max used sugar is {максимално количество грамове захар, използвани за правенето на козунак} grams."
            //Пакетите захар и брашно да бъдат закръглени към най - близкото цяло число нагоре.
            int numBred = int.Parse(Console.ReadLine());
            double counterSugar = 0;
            double counterFlour = 0;
            double maxFlour = 0;
            double maxSugar = 0;
            for (int i = 1; i <= numBred; i++)
            {
                double sugar = double.Parse(Console.ReadLine());
                double flour = double.Parse(Console.ReadLine());
                counterSugar += sugar;
                counterFlour += flour;
                if (sugar>maxSugar )
                {
                    maxSugar = sugar;
                }
                if (flour>maxFlour)
                {
                    maxFlour = flour;
                }
            }
            double packageSugar =Math.Ceiling(counterSugar/950);
            double packageFlour = Math.Ceiling(counterFlour/750);
            Console.WriteLine($"Sugar: {packageSugar}");
            Console.WriteLine($"Flour: {packageFlour}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
