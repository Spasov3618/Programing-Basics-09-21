using System;

namespace Fitness
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която да изчислява броя на посетителите в един фитнес център.
            //В началото програмата получава броя на посетителите на фитнеса и за всеки човек - дейността, която извършва във фитнеса.
            //На края програмата трябва да отпечата броят трениращи за всяка една дейност("Back", "Chest", 'Legs", "Abs") и броят клиенти,
            //закупили продукт ("Protein shake", "Protein bar"). Също така - процентът трениращи (спрямо общия брой посетители) и процентът на клиентите, закупили продукт от фитнеса.
            //Вход
            //От конзолата се чете число, след това поредица от низове, всяко на отделен ред:
            //•	На първия ред – броят на посетителите във фитнеса – цяло число в интервала[1...1000]
            //•	За всеки един посетител на отделен ред – дейността във фитнеса – текст("Back", "Chest", "Legs", "Abs", "Protein shake" или "Protein bar")
            //Изход
            //Да се отпечатат на конзолата 8 реда, които съдържат следната информация:
            //Ред 1 - "{брой хора трениращи гръб} - back"
            //Ред 2 - "{брой хора трениращи гърди} - chest"
            //Ред 3 - "{брой хора трениращи крака} - legs"
            //Ред 4 - "{брой хора трениращи коремни мускули} - abs"
            //Ред 5 - "{брой хора закупили протеинов шейк} - protein shake"
            //Ред 6 - "{брой хора закупили протеинов блок} - protein bar"
            //Ред 7 - "{процент на хората дошли да тренират}% - work out"
            //Ред 8 - "{процент на хората дошли да купят протеин}% - protein"
            //Всички проценти трябва да са форматирани до втората цифра след десетичния знак
            double numVisitors = double.Parse(Console.ReadLine());
            double counterBack = 0;
            double counterChest = 0;
            double counterLegs = 0;
            double counterAbs = 0;
            double counterShake = 0;
            double counterBar = 0;
               

            for (int i = 1; i <= numVisitors; i++)
            {
                string work = Console.ReadLine();
                switch (work)
                {
                    case "Back":
                        counterBack++;
                        break;
                    case "Chest":
                        counterChest++;
                        break;
                    case "Legs":
                        counterLegs++;
                        break;
                    case "Abs":
                        counterAbs++;
                        break;
                    case "Protein shake":
                        counterShake++;
                        break;
                    case "Protein bar":
                        counterBar++;
                        break;
                }
            }
            double percentTraining = ((counterBack + counterChest + counterLegs + counterAbs) / numVisitors) * 100;
            double percentBay = ((counterShake + counterBar) / numVisitors) * 100;
            Console.WriteLine($"{counterBack} - back");
            Console.WriteLine($"{counterChest} - chest");
            Console.WriteLine($"{counterLegs} - legs");
            Console.WriteLine($"{counterAbs} - abs");
            Console.WriteLine($"{counterShake} - protein shake");
            Console.WriteLine($"{counterBar} - protein bar");
            Console.WriteLine($"{percentTraining:f2}% - work out");
            Console.WriteLine($"{percentBay:f2}% - protein");
        }
    }
}
