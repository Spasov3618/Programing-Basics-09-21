using System;

namespace Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            //За великденските празници, магазин започва да продава три вида великденска украса – кошнички за яйца(basket), великденски венци(wreath) и шоколадови зайци(chocolate bunny).Вашата задача е да напишете програма, която да изчислява каква сметка трябва да плати всеки един клиент на магазина, като се има в предвид, че всеки клиент закупил четен брой продукти, ще получи 20 % отстъпка от крайната цена.След като всички клиенти приключат с покупките, трябва да се отпечата средно по колко пари е похарчил всеки човек.
            //Цените на продуктите са:
            //•	кошничка за яйца(basket) – 1.50 лв.
            //•	великденски венец(wreath) – 3.80 лв.
            //•	шоколадов заек(chocolate bunny) – 7 лв.
            //Вход
            //От конзолата първоначално се чете един ред:
            //•	Брои на клиентите в магазина – цяло число[1… 100]
            //•	След това за всеки един клиент на нов ред до получаване на командата "Finish" се чете:
            //o Покупката която клиента е избрал – текст("basket", "wreath" или "chocolate bunny")
            //Изход
            //•	При получаване на командата "Finish" да се отпечата един ред:
            //            o   "You purchased {броя на покупките} items for {крайната цена} leva."
            //•	Накрая, след като всички клиенти приключат с покупките, да се отпечата на един ред
            //o   "Average bill per client is: {средно аритметично на парите които е похарчил всеки един клиент} leva."
            //Всички пари трябва да бъдат форматирани до втората цифра след десетичния знак.
            
            double money = 0;
            double counter = 0;
            double numClient = double.Parse(Console.ReadLine());
            for (int i = 0; i < numClient; i++)
            {
                string input = Console.ReadLine();
                double moneyNow = 0;
                double counterNow = 0;
                while (input!= "Finish")
                {
                    switch (input)
                    {
                        case "basket":
                            moneyNow += 1.50;
                            counterNow++;
                            counter++;
                            break;
                        case "wreath":
                            moneyNow += 3.80;
                            counterNow++;
                            counter++;
                            break;
                        case "chocolate bunny":
                            moneyNow += 7;
                            counterNow++;
                            counter++;
                            break;
                    }
                    input = Console.ReadLine();
                    }
                    if (counterNow % 2== 0)
                    {
                        moneyNow *= 0.8;
                }
                    if (input == "Finish")
                    {
                        Console.WriteLine($"You purchased {counterNow} items for {moneyNow:f2} leva.");
                    }
                    money += moneyNow;
                
            }
            Console.WriteLine($"Average bill per client is: {money/numClient:f2} leva.");
        }
    }
}
