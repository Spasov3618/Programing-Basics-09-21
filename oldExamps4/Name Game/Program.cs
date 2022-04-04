using System;

namespace Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Иван е измислил нова игра в която да се състезава със своите приятели.Вашата задача е да напишете програма за играта.
            //Всеки играч написва името си, след това за всяка една буква от името си написва по едно цяло число,
            //ако числото съвпада с ASCII стойността на съответната буква, играчът получава 10 точки,
            //в противен случай, получава само 2 точки.Победител е играчът с най - много точки в края на играта.В случай,
            //че двама играчи имат равен брой точки, печели този, който втори е достигнал резултата.
            //Вход
            //До получаване на командата "Stop" се чете по един ред:
            //•	Име на играча с дължина n -текст
            //За всеки играч се четат n на брой реда:
            //•	число – цяло число в интервала[0…127]
            //Изход
            //Да се отпечата един ред в следния формат:
            //•	"The winner is {името на победителя} with {точките на победителя} points!"
            string namePlayer = Console.ReadLine();
            double pointsPlayer = 0;
            double bestPlayer = 0;
            string nameBestPlayer = "";
            while (namePlayer != "Stop")
            {
                double pointsW = 0;
                double pointsL = 0;
                for (int i = 0; i < namePlayer.Length; i++)
                {
                    double num = double.Parse(Console.ReadLine());
                    char sing = namePlayer[i];
                    if (num == sing)
                    {
                        pointsW++;
                    }
                    else if (num != sing)
                    {
                        pointsL++;
                    }
                }
            
                pointsPlayer = pointsW * 10 + pointsL * 2;
                if (bestPlayer <= pointsPlayer)
                {
                    bestPlayer = pointsPlayer;
                    nameBestPlayer = namePlayer;
                }
            
                
                namePlayer = Console.ReadLine();
            }
            Console.WriteLine($"The winner is {nameBestPlayer} with {bestPlayer} points!");
        }
    }
}
