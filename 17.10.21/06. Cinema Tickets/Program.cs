using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {

            string nameOfFilm = Console.ReadLine();
            int countner = 0;
            int ollstudentTikket = 0;
            int ollstandartTikket = 0;
            int ollkidTikket = 0;
            while (nameOfFilm != "Finish")
            {
                int studentTikket = 0;
                int standartTikket = 0;
                int kidTikket = 0;
                int place = int.Parse(Console.ReadLine());
                for (int i = 0; i < place; i++)
                {
                    string tikket = Console.ReadLine();
                    if (tikket == "End")
                    {
                        break;
                    }
                    switch (tikket)
                    {

                        case "student":

                            studentTikket++;
                            countner++;
                            ollstudentTikket++;
                            break;

                        case "standard":

                            standartTikket++;
                            countner++;
                            ollstandartTikket++;
                            break;

                        case "kid":

                            kidTikket++;
                            countner++;
                            ollkidTikket++;
                            break;
                    }
                }

                int salePlaces = studentTikket + standartTikket + kidTikket;
                double percent = 1.0 * salePlaces / place * 100;
                Console.WriteLine($"{nameOfFilm} - {percent:f2}% full.");
                nameOfFilm = Console.ReadLine();
            }
        

                double percentStudent = 1.0 * ollstudentTikket / countner *100;
                double percentStandard = 1.0 * ollstandartTikket / countner*100;
                double percentKid = 1.0 * ollkidTikket / countner*100;
                Console.WriteLine($"Total tickets: {countner}");
                Console.WriteLine($"{percentStudent:f2}% student tickets.");
                Console.WriteLine($"{percentStandard:f2}% standard tickets.");
                Console.WriteLine($"{percentKid:f2}% kids tickets.");
           
            }
    }
}
