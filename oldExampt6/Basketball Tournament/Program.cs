﻿using System;

namespace Basketball_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            //Деси и отборът ѝ по баскетбол участват в турнири всеки месец, като всеки турнир се състои от определен брой мачове.
            //Всеки мач има краен резултат, на базата на който се определя победителят.Отборът, вкарал повече точки, се смята за победител.
            //Помогнете на Деси да направи статистика за турнирите, в които участва с отбора си.
            //Като вход ще получавате имена на турнири до получаване на команда "End of tournaments".За всеки турнир ще получавате цяло число,
            //което ще показва броя на мачовете, които се играят за турнир.За всеки мач ще получавате: на първия ред точките, които е вкарал отборът на Деси,
            //а на втория ред -точките, които е вкарал противниковият отбор.След получаване на точките за всеки мач отпечатайте:
            //	Ако отборът на Деси е спечелил(т.е.точките, които е вкарал нейният отбор, са повече от точките на противниковия отбор): "Game {кой е номерът на мача,
            //който са изиграли за текущия турнир} of tournament {име на турнира}: win with {разликата между точките на отбора на Деси и противниковия отбор} points."
            //	Ако отборът на Деси е загубил(т.е.точките, които е вкарал нейният отбор, са по-малко от точките, които е вкарал противниковият отбор):
            //"Game {кой е номерът на мача, който са изиграли за текущия турнир} of tournament {име на турнира}:
            //lost with {разликата между точките на противниковия отбор и отбора на Деси} points."
            //Няма да има случаи на равенство.
            //Вход
            //От конзолата се четат поредица от турнири до получаване на командата "End of tournaments":
            //•	Име на турнира – текст
            //•	За всеки турнир n на брой мача – цяло число в интервала[1…15]
            //•	За всеки мач се четат по два реда:
            //o Точки, вкарани от отбора на Деси – цяло число в интервала от[0…150]
            //o Точки, вкарани от противниковия отбор – цяло число в интервала от[0…150]
            //Изход
            //На конзолата да се отпечатат следните редове:
            //•	След всеки мач да се отпечатва дали отборът на Деси е спечелил или загубил и съответно с каква разлика.
            //•	При получаване на команда "End of tournaments" да се отпечатат два реда:
            //            o   { процент спечелени мачове от всички турнири}% matches win
            //             o   { процент загубени мачове от всички турнири}% matches lost
            //              Всички проценти трябва да са форматирани до втората цифра след десетичния знак.
            string nameTournament = Console.ReadLine();
            double counterWin = 0;
            double counterLost = 0;
                double counterGames = 0;
            while (nameTournament!= "End of tournaments")
            {
                double numGames = double.Parse(Console.ReadLine());
                counterGames += numGames;
                for (int i = 1; i <= numGames; i++)
                {
                    double pointsDesi = double.Parse(Console.ReadLine());
                    double points2 = double.Parse(Console.ReadLine());
                    if (pointsDesi>points2)
                    {
                        counterWin++;
                        Console.WriteLine($"Game {i} of tournament {nameTournament}: win with {pointsDesi-points2} points.");
                    }
                    else
                    {
                        counterLost++;
                        Console.WriteLine($"Game {i} of tournament {nameTournament}: lost with {points2-pointsDesi} points.");
                    }
                }
                nameTournament = Console.ReadLine();
            }
            if (nameTournament == "End of tournaments")
            {
                double percentWin = counterWin / counterGames * 100;
                double percentLost = counterLost / counterGames * 100;
                Console.WriteLine($"{percentWin:f2}% matches win");
                Console.WriteLine($"{percentLost:f2}% matches lost");

            }
        }
    }
}
