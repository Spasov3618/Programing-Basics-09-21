using System;

namespace Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {
            //            John Wick       Star Wars          Jumanji
            //Напитка       12 лв./ бр.    18 лв. / бр.       9 лв. / бр.
            //Пуканки       15 лв. / бр.   25 лв. / бр.      11 лв. / бр.
            // Меню         19 лв. / бр.    30 лв. / бр.     14 лв. / бр.

            //Напишете програма, която изчислява цената, която трябва да се заплати, като имате в предвид следните отстъпки:
            //•	При избран филм "Star Wars" и закупени поне четири билета, има 30 % семейна отстъпка.
            //•	При избран филм "Jumanji" и закупени точно два билета, има 15 % отстъпка за двама.
            //Вход
            //Входът се чете от конзолата и се състои от три реда:
            //•	Първи ред -прожекция - текст с възможности"John Wick", "Star Wars" или "Jumanji"
            //•	Втори ред -пакет за филм -текст  с възможности "Drink", "Popcorn" или "Menu"
            //•	Трети ред -брой билети - цяло число в интервала[1… 30]
            //Изход
            //На конзолата трябва да се отпечата един ред:
            //            "Your bill is {крайна цена} leva."
            //Цената да бъде закръглена до втората цифра след десетичния знак.
            string name = Console.ReadLine();
            string packet = Console.ReadLine();
            double numTicket = double.Parse(Console.ReadLine());
            double total = 0;
            switch (name)
            {
                case "John Wick":
                    switch (packet)
                    {
                        case "Drink":
                            total = numTicket * 12;
                            break;
                        case "Popcorn":
                            total = numTicket * 15;
                            break;
                        case "Menu":
                            total = numTicket * 19;
                            break;
                    }
                    break;
                case "Star Wars":
                    switch (packet)
                    {
                        case "Drink":
                            total = numTicket * 18;
                            break;
                        case "Popcorn":
                            total = numTicket * 25;
                            break;
                        case "Menu":
                            total = numTicket * 30;
                            break;
                    }
                    break;
                    
                case "Jumanji":
                    switch (packet)
                    {
                        case "Drink":
                            total = numTicket * 9;
                            break;
                        case "Popcorn":
                            total = numTicket * 11;
                            break;
                        case "Menu":
                            total = numTicket * 14;
                            break;
                    }
                    break;

            }
            if (name== "Star Wars" && numTicket>=4)
            {
                total *= 0.7;
            }
            if (name== "Jumanji" && numTicket==2)
            {
                total *= 0.85;
            }
            Console.WriteLine($"Your bill is {total:f2} leva.");
        }
    }
}
