using System;

namespace Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            //Футболен отбор участва в благотворителен турнир. На този турнир отборът играе три мача като домакин.
            //Да се напише програма, която изчислява колко победи, равенства и загуби има отборът по време на турнира, спрямо резултатите от мачовете.
            //*Забележка: Отборът винаги е домакин, следователно първата цифра от резултата съответства на головете вкарани от него.
            //Вход
            //От конзолата се четат 3 реда:
            //1.Резултат от първия мач – текст
            //2.Резултат от втория мач – текст
            //3.Резултат от третия мач – текст
            //Резултатите ще са в следния формат: "2:0", "0:1", "1:1" и т.н.
            /// броят голове винаги ще бъде едноцифрено число/
            //Изход
            //На конзолата да се отпечатат три реда:
            //•	"Team won {брой спечелени мачове} games."
            //•	"Team lost {брой загубени мачове} games."
            //•	" Drawn games: {брой равни мачове}"
            string match1 = Console.ReadLine();
            string match2 = Console.ReadLine();
            string match3 = Console.ReadLine();
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            char rezult1 = match1[0];
            char rezult2 = match1[2];
            char rezult3 = match2[0];
            char rezult4 = match2[2];
            char rezult5 = match3[0];
            char rezult6 = match3[2];
            if (rezult1>rezult2)
            {
                counter1++;
            }
            else if (rezult1==rezult2)
            {
                counter2++;
            }
            else
            {
                counter3++;
            }
            if (rezult3 > rezult4)
            {
                counter1++;
            }
            else if (rezult3 == rezult4)
            {
                counter2++;
            }
            else
            {
                counter3++;
            }
            if (rezult5 > rezult6)
            {
                counter1++;
            }
            else if (rezult5 == rezult6)
            {
                counter2++;
            }
            else
            {
                counter3++;
            }
            Console.WriteLine($"Team won {counter1} games.");
            Console.WriteLine($"Team lost {counter3} games.");
            Console.WriteLine($"Drawn games: {counter2}");
        }
    }
}
