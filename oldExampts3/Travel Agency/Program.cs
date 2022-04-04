using System;

namespace Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            //Туристическа агенция има нужда от система за изчисляване на дължимата сума при резервация.В зависимост от различните дестинации и различните пакети, цената е различна.
            //Цените за ден са следните:
            // Цена за ден	   Банско/Боровец	                   Варна/Бургас
            //            с екипировка    без екипировка  със закуска   без закуска

            //                  100лв.            80лв        130лв.      100лв.
            //VIP отстъпка        10 %            5 %           12 %         7 %

            //Ако клиентът е заявил престой повече от 7 дни, получава единия ден безплатно.
            
            //Изход
            //На конзолата се отпечатва 1 ред:
            //•	Когато потребителят е въвел всички данни правилно, отпечатваме:
            //"The price is {цената, форматирана до втория знак}lv! Have a nice time!"
            //•	Ако потребителят е въвел по - малко от 1 ден за престой, отпечатваме:
            // "Days must be positive number!"
            //•	Когато при въвеждането на града или вида на пакета се въведат невалидни данни, отпечатваме: "Invalid input!"
            string city = Console.ReadLine();
            string packet = Console.ReadLine();
            string vip = Console.ReadLine();
            int numDay = int.Parse(Console.ReadLine());
            double numDayMore = numDay;
            double total = 0;
            if (numDay < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            if (numDay > 7)
            {
                numDayMore = numDay - 1;
            }
            if (city != "Bansko" && city!= "Borovets" && city != "Varna" && city!= "Burgas" || packet != "noEquipment" && packet != "withEquipment" && packet != "noBreakfast"&& packet!=  "withBreakfast") 
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            switch (packet )
            {
                case "noEquipment":
                  
                    total = numDayMore * 80;
                    if (vip == "yes")
                    {
                        total *= 0.95;
                    }
                    
                break;
                case "withEquipment":
                    total = numDayMore * 100;
                    if (vip == "yes")
                    {
                        total *= 0.9;
                    }
                    break;
                case "noBreakfast":
                    total = numDayMore * 100;
                    if (vip == "yes")
                    {
                        total *= 0.93;
                    }
                    break;
                case "withBreakfast":
                    total = numDayMore * 130;
                    if (vip == "yes")
                    {
                        total *= 0.88;
                    }
                    break;
            }
            Console.WriteLine($"The price is {total:f2}lv! Have a nice time!");
        }
    }
}
