using System;

namespace Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //•	Ако отборът е изиграл един мач или повече се извеждат шест реда в следния формат:
            //            o   "{името на отбора} has won {брой спечелени точки} points during this season"
            //o   "Total stats:"
            //o   "## W: {брой спечелени игри}"
            //o   "## D: {брой игри, завършили наравно}"
            //o   "## L: {брой загубени игри}"
            //o   "Win rate: {процент спечелени игри}%"
            //Процентът спечелени игри трябва да бъде форматиран до втората цифра след десетичния знак.
            string nameTeam = Console.ReadLine();
            double numMeetings = double.Parse(Console.ReadLine());
            double counterW = 0;
            double counterD = 0;
            double counterL = 0;
            if (numMeetings == 0)
            {
                Console.WriteLine($"{nameTeam} hasn't played any games during this season.");
                return;
            }
            for (int i = 1; i <= numMeetings; i++)
            {
                string rezult = Console.ReadLine();
                switch (rezult)
                {
                    case "W":
                        counterW++;
                        break;
                    case "D":
                        counterD++;
                        break;
                    case "L":
                        counterL++;
                        break;
                }
            }
            double points = counterW * 3 + counterD;
            double percentW = counterW / numMeetings * 100;
            Console.WriteLine($"{nameTeam} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {counterW}");
            Console.WriteLine($"## D: {counterD}");
            Console.WriteLine($"## L: {counterL}");
            Console.WriteLine($"Win rate: {percentW:f2}%");
        }
    }
}
