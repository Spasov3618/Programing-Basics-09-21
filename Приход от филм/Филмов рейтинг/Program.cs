using System;

namespace Филмов_рейтинг
{
    class Program
    {
        static void Main(string[] args)
        {
            //Деси много обича да гледа филми, но често й е трудно да си избере подходящ за гледане.
            //Набелязва си определен брой филми и иска да си избере кой филм да гледа спрямо рейтинга на филмите.
            //Напишете програма, която показва кой филм е с най-висок рейтинг, кой е с най-нисък и колко е средният рейтинг от всички филми,
            //които си е набелязала да гледа.
            //Вход
            //От конзолата първо се чете един ред:
            //•	Брой филми, които си е набелязала Деси – цяло число в интервала[1…20]
            //За всеки филм се прочитат два отделни реда:
            //•	Име на филма – текст
            //•	Рейтинг на филма - реално число в интервала[1.00…10.00]
            //Изход
            //Отпечатват се три реда в следния формат:
            //•	"{име на филма с най-висок рейтинг} is with highest rating: {рейтинг на филма}"
            //•	"{име на филма с най-нисък рейтинг} is with lowest rating: {рейтинг на филма}"
            //•	"Average rating: {средният рейтинг на всички филми}"
            //Максималният, минималният и средният рейтинг да се форматира до първата цифра след десетичния знак.
            int numFilms = int.Parse(Console.ReadLine());
            double maxReiting = double.MinValue ;
            double minReiting = double.MaxValue;
            double totalReiting = 0;
            string maxFilm = "";
            string minFilm = "";
            for (int i = 0; i < numFilms; i++)
            {
                string nameFilm = Console.ReadLine();
                double reiting = double.Parse(Console.ReadLine());
                if (maxReiting<reiting)
                {
                    maxReiting = reiting;
                    
                    maxFilm = nameFilm;
                   
                }
                if (reiting <minReiting)
                {
                    minReiting = reiting;
                   
                    minFilm = nameFilm;
                }
                totalReiting += reiting;
            }
            double average = totalReiting / numFilms;
            Console.WriteLine($"{maxFilm} is with highest rating: {maxReiting:f1}");
            Console.WriteLine($"{minFilm} is with lowest rating: {minReiting:f1}");
            Console.WriteLine($"Average rating: {average:f1}");
        }
    }
}
