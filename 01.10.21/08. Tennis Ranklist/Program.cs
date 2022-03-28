using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            const int w = 2000;
            const int f = 1200;
            const int sf = 720;
            int numTournament = int.Parse(Console.ReadLine());
            int numPointsStart = int.Parse(Console.ReadLine());
            int totalPoints = 0;
            int winnerTournaments = 0;
            //Напишете програма, която изчислява колко ще са точките на Григор след изиграване на всички турнири,
            //като знаете с колко точки стартира сезона.Също изчислете колко точки средно печели от всички изиграни турнири и колко процента от турнирите е спечелил.
            for (int i = 0; i < numTournament; i++)
            {
                string tournament = Console.ReadLine();

                if (tournament == "W")
                {
                    totalPoints += w;
                    winnerTournaments++;
                }
                else if (tournament == "F")
                {
                    totalPoints += f;
                }
                else if (tournament == "SF")
                {
                    totalPoints += sf;
                }
            }
            int total = totalPoints + numPointsStart;
            Console.WriteLine($"Final points: {total}");
            Console.WriteLine($"Average points: {Math .Floor( 1.0 * totalPoints /numTournament) }");
            double persent = 1.0 * winnerTournaments / numTournament * 100;
            Console.WriteLine($"{persent:f2}%");
            //За всеки турнир се прочита отделен ред:
            //•	Достигнат етап от турнира – текст – "W", "F" или "SF"
            //Изход
            //Отпечатват се три реда в следния формат:
            //•	"Final points: {брой точки след изиграните турнири}"
            //•	"Average points: {средно колко точки печели за турнир}"
            //•	"{процент спечелени турнири}%"
            //Средните точки да бъдат закръглени към най - близкото цяло число надолу, а процентът да се
            //форматира до втората цифра след десетичния знак.

        }
    }
}
