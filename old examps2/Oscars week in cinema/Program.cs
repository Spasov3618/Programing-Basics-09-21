using System;

namespace Oscars_week_in_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nameFilm = Console.ReadLine();
            string zala = Console.ReadLine();
            double numTicket = double.Parse(Console.ReadLine());
            double totalMoney = 0;
            switch (nameFilm )
            {
                case "A Star Is Born":
                    if (zala == "normal")
                    {
                        totalMoney = numTicket *7.5 ;
                    }
                    else if (zala == "luxury")
                    {
                        totalMoney = numTicket * 10.5;
                    }
                    else if (zala == "ultra luxury")
                    {
                        totalMoney = numTicket *13.5 ;
                    }
                    break;
                case "Bohemian Rhapsody":
                    if (zala == "normal")
                    {
                        totalMoney = numTicket *7.35 ;
                    }
                    else if (zala == "luxury")
                    {
                        totalMoney = numTicket * 9.45;
                    }
                    else if (zala == "ultra luxury")
                    {
                        totalMoney = numTicket * 12.75;
                    }
                    break;
                case "Green Book":
                    if (zala == "normal")
                    {
                        totalMoney = numTicket * 8.15;
                    }
                    else if (zala == "luxury")
                    {
                        totalMoney = numTicket *10.25 ;
                    }
                    else if (zala == "ultra luxury")
                    {
                        totalMoney = numTicket * 13.25;
                    }
                    break;
                case "The Favourite":
                    if (zala == "normal")
                    {
                        totalMoney = numTicket *8.75 ;
                    }
                    else if (zala == "luxury")
                    {
                        totalMoney = numTicket *11.55 ;
                    }
                    else if (zala == "ultra luxury")
                    {
                        totalMoney = numTicket *13.95 ;
                    }
                    break;
            }

            Console.WriteLine($"{nameFilm} -> {totalMoney:f2} lv.");
        }
    }
}
