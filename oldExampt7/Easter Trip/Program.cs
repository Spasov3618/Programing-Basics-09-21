using System;

namespace Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дестинация      21 - 23 март      24 - 27 март       28 - 31 март
            //Франция           30 лв.          35 лв.              40 лв.
            //Италия             28 лв.         32 лв.             39 лв.
            //Германия           32 лв.         37 лв.             43 лв.
            //Входът се чете от конзолата и се състои от три реда:
            //•	Първи ред -дестинация - текст с възможности"France", "Italy" или "Germany"
            //•	Втори ред -дати, през които си е резервирала екскурзията -текст  с възможности "21-23", 
            //"24-27" или "28-31"
            //•	Трети ред -брой нощувки - цяло число в интервала[1… 100]
            //Изход
            //На конзолата трябва да се отпечата един ред:
            //"Easter trip to {дестинация} : {разходи за екскурзията} leva."
            //Разходите за екскурзията да бъдат форматирани до втората цифра след десетичния знак.
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());
            double price = 0;
            switch (destination)
            {
                case "France":
                    switch (dates)
                    {
                        case "21-23":
                            price = numNights * 30;
                            break;
                        case "24-27":
                            price = numNights * 35;
                            break;
                        case "28-31":
                            price = numNights * 40;
                            break;
                    }
                    break;
            
                case "Italy":
                    switch (dates)
                    {
                        case "21-23":
                            price = numNights * 28;
                            break;
                        case "24-27":
                            price = numNights * 32;
                            break;
                        case "28-31":
                            price = numNights * 39;
                            break;
                    }
                            break;
                case "Germany":
                    switch (dates)
                    {
                        case "21-23":
                            price = numNights * 32;
                            break;
                        case "24-27":
                            price = numNights * 37;
                            break;
                        case "28-31":
                            price = numNights * 43;
                            break;
                    }
                                    break;
            }
            Console.WriteLine($"Easter trip to {destination} : {price:f2} leva.");
        }
    }
}
