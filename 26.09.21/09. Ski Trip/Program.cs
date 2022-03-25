using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {

            //Намаленията са както следва:
            //вид помещение   по - малко от 10 дни между 10 и 15 дни повече от 15 дни
            //room for one person не ползва намаление не ползва намаление не ползва намаление
            //apartment   30 % от крайната цена    35 % от крайната цена    50 % от крайната цена
            //president apartment 10 % от крайната цена    15 % от крайната цена    20 % от крайната цена
            //След престоя, оценката на Атанас за услугите на хотела може да е позитивна(positive) или негативна(negative).Ако оценката му е позитивна,
            //към цената с вече приспаднатото намаление Атанас добавя 25 % от нея.Ако оценката му е негативна приспада от цената 10 %.

            // "room for one person", "apartment" или "president apartment"

            const double priceRoomForOnePerson = 18;
            const double priceApartment = 25;
            const double pricePresidentApartment = 35;
            int dni = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();
            double totalPrice = 0;
            int naits = dni - 1;
            if (naits < 10)
            {
                switch (room)
                {
                    case "room for one person":
                        totalPrice = priceRoomForOnePerson * naits;
                        break;
                    case "apartment":
                        totalPrice = priceApartment * naits;
                        totalPrice -= totalPrice * 0.3;
                        break;
                    case "president apartment":
                        totalPrice = pricePresidentApartment * naits;
                        totalPrice -= totalPrice * 0.1;
                        break;
                }
            }
            else if (naits >= 10 && naits < 15)
            {
                switch (room)
                {
                    case "room for one person":
                        totalPrice = priceRoomForOnePerson * naits;
                        break;
                    case "apartment":
                        totalPrice = priceApartment * naits;
                        totalPrice -= totalPrice * 0.35;
                        break;
                    case "president apartment":
                        totalPrice = pricePresidentApartment * naits;
                        totalPrice -= totalPrice * 0.15;
                        break;
                }
            }
            else if (naits >= 15)
            {
                switch (room)
                {
                    case "room for one person":
                        totalPrice = priceRoomForOnePerson * naits;
                        break;
                    case "apartment":
                        totalPrice = priceApartment * naits;
                        totalPrice -= totalPrice * 0.50;
                        break;
                    case "president apartment":
                        totalPrice = pricePresidentApartment * naits;
                        totalPrice -= totalPrice * 0.20;
                        break;
                }
            }
            if (rating == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else if (rating == "negative")
            {
                totalPrice -= totalPrice * 0.1;
            }
            {
                Console.WriteLine($"{totalPrice:f2}");
            }
        }

    }
}
