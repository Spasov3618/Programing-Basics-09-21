using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Петък вечер е и се чудите кой филм да си пуснете да гледате.Решавате да напишете програма,
            //която да избере това вместо вас.До команда "STOP" получавате заглавия на любими ваши филми.
            //Най - добрият филм за вас ще бъде този, който има най-много точки.
            //Точките се изчисляват като сбор от ASCII стойностите на символите в заглавието на филма. (няма да има случай, в който имаме два филма с равен брой точки)
            //При изчислението на точките трябва да се има предвид следното:
            //•	За всяка малка буква в заглавието, от сумата трябва да се извади два пъти дължината на заглавието на филма.
            //•	За всяка главна буква в заглавието, от сумата трябва да се извади дължината на заглавието на филма.
            //Може да имате максимум 7 заглавия на филми.
            //Вход
            //От конзолата се четат редове до команда "STOP" или до достигането на лимита от 7 филма:
            //•	Заглавие на филм  – текст;
            //            Изход
            //            На конзолата да се отпечата:
            //•	Ако сте достигнали лимита от 7 филма трябва да отпечатате:
            //"The limit is reached."
            //Да се отпечата най-добрият филм за вас:
            //            "The best movie for you is {заглавие на филм} with {сума на символите} ASCII sum."
            double points = 0;
            string bestMovie = "";
                double counter = 0;
            for (int i = 0; i < 7; i++)
            {
             string nameMovie = Console.ReadLine();
                double pointMovie = 0;
                if (nameMovie=="STOP")
                {
                    break;
                }
                counter++;
                double inputLength = nameMovie.Length;
                for (int  j = 0; j < nameMovie.Length; j++)
                {
                    char symbol = nameMovie[j];
                    if (symbol >=65 && symbol<=90)
                    {
                        pointMovie += symbol - inputLength; ;
                    }
                    else if (symbol>=97&&symbol<=122)
                    {
                        pointMovie += symbol - (2 * inputLength);
                    }
                    else
                    {
                        pointMovie += symbol;
                    }
                }
                if (points <pointMovie)
                {
                    points = pointMovie;
                    bestMovie = nameMovie;
                }
                    
            }
            if (counter==7)
            {
                Console.WriteLine("The limit is reached.");
            }
            Console.WriteLine($"The best movie for you is {bestMovie} with {points} ASCII sum.");
        }
    }
}
