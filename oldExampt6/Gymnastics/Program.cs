using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            //                    Четвъртфинал        Полуфинал               Финал
            //Стандартен             55.50 £/ бр.      75.88 £/ бр.          110.10 £/ бр.
            //Премиум               105.20 £/ бр.     125.22 £/ бр.          160.66 £/ бр.
            //ВИП                   118.90 £/ бр.      300.40 £/ бр.            400 £/ бр.
            //При закупуване на билет, зрителят може да избере опция, снимка с трофея, на цена 40 лири.
            //При достигане на определена сума има отстъпки:
            //•	Над 4000 лири има 25 % отстъпка и безплатни снимки с трофея(ако  опцията за снимки е избрана, таксата от 40 лири за билет не се включва)
            //•	Над 2500 лири има 10 % отстъпка
            //При избрана опция за снимки с трофея, цената се начислява след изчисляването на отстъпките.
            //Вход
            //От конзолата се четат 3 реда:
            //            1.Етап на първенството – текст - “Quarter final ”, “Semi final” или “Final”
            //2.Вид на билета – текст - “Standard”, “Premium” или “VIP”
            //3.Брой билети – цяло число в интервала[1 … 30]
            //4.Снимка с трофея – символ – 'Y'(да) или 'N'(не)
            //Изход
            //На конзолата се отпечатва 1 ред:
            //•	"Цената, която трябва да се заплати, форматирана до втората цифра след десетичния знак"
            string etap = Console.ReadLine();
            string ticket = Console.ReadLine();
            double numTicket = double.Parse(Console.ReadLine());
            string pic = Console.ReadLine();
            double total = 0;
            switch (etap)
            {
                case "Quarter final":
                    switch (ticket)
                    {
                        case "Standard":
                            total = numTicket * 55.50;
                            break;
                        case "Premium":
                            total = numTicket * 105.20;
                            break;
                        case "VIP":
                            total = numTicket * 118.90;
                            break;
                    }
                    break;
                case "Semi final":
                    switch (ticket)
                    {
                        case "Standard":
                            total = numTicket * 75.88;
                            break;
                        case "Premium":
                            total = numTicket * 125.22;
                            break;
                        case "VIP":
                            total = numTicket * 300.40;
                            break;
                    }
                    break;
                case "Final":
                    switch (ticket)
                    {
                        case "Standard":
                            total = numTicket * 110.10;
                            break;
                        case "Premium":
                            total = numTicket * 160.66;
                            break;
                        case "VIP":
                            total = numTicket * 400;
                            break;
                    }
                    break;
            }
            if (total>=2500 && total<=4000)
            {
                total *= 0.9;
            }
            if (pic=="Y" && total <4000)
            {
                total += numTicket* 40;
            }
            if (total>4000)
            {
                total *= 0.75;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
