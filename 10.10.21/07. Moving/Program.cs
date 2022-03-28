using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //Потребителят въвежда следните данни на отделни редове:
            //1.Широчина на свободното пространство - цяло число в интервала[1...1000]
            //2.Дължина на свободното пространство - цяло число в интервала[1...1000]
            //3.Височина на свободното пространство - цяло число в интервала[1...1000]
            //4.На следващите редове(до получаване на команда "Done") -брой кашони, които се пренасят в квартирата - цяло число в интервала[1...10000]
            //Програмата трябва да приключи прочитането на данни при команда "Done" или ако свободното място свърши.
            //Изход
            //Да се отпечата на конзолата един от следните редове:
            //•	Ако стигнете до командата "Done" и има още свободно място:
            //"{брой свободни куб. метри} Cubic meters left."
            //•	Ако свободното място свърши преди да е дошла команда "Done":
            //"No more free space! You need {брой недостигащи куб. метри} Cubic meters more."
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int freespace = w * l * h;
            while (freespace > 0)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    Console.WriteLine($"{freespace} Cubic meters left.");
                    break;
                }
                int free = int.Parse(input);
                freespace -= free;


                if (freespace <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freespace)} Cubic meters more.");
                }
            }
        }
    }
}
