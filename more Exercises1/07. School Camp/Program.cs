using System;

namespace _07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string boi = Console.ReadLine();
            double numStudents = double.Parse(Console.ReadLine());
            double numDay = double.Parse(Console.ReadLine());
            string sport = "";
            double price = 0;
            switch (season)
            {
                case "Winter":
                    if (boi == "boys")
                    {
                        sport = "Judo";
                        price = numStudents * numDay * 9.60;
                    }
                    else if (boi == "girls")
                    {
                        sport = "Gymnastics";
                        price = numStudents * numDay * 9.60;
                    }
                    else if (boi == "mixed")
                    {
                        sport = "Ski";
                        price = numStudents * numDay * 10.00;
                    }
                    break;
                case "Spring":
                    if (boi == "boys")
                    {
                        sport = "Tennis";
                        price = numStudents * numDay * 7.20;
                    }
                    else if (boi == "girls")
                    {
                        sport = "Athletics";
                        price = numStudents * numDay * 7.20;
                    }
                    else if (boi == "mixed")
                    {
                        sport = "Cycling";
                        price = numStudents * numDay * 9.50;
                    }
                    break;
                case "Summer":
                    if (boi == "boys")
                    {
                        sport = "Football";
                        price = numStudents * numDay * 15.00;
                    }
                    else if (boi == "girls")
                    {
                        sport = "Volleyball";
                        price = numStudents * numDay * 15.00;
                    }
                    else if(boi == "mixed")
                    {
                        sport = "Swimming";
                        price = numStudents * numDay * 20.00;
                    }
                    break;

            }
            if (numStudents >=10 && numStudents <20)
            {
                price *= 0.95;
            }
            else if (numStudents >=20 && numStudents < 50)
            {
                price *= 0.85;
            }
            else if (numStudents >50)
            {
                price *= 0.5;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
