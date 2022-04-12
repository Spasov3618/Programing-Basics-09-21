using System;

namespace Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вашата задача е да напишете програма, която да изчислява, дали даден играч е успял да спечели лег. (Лег се нарича единична игра на дартс)
            //Първоначално играчът започва с 301 точки.Играчът хвърля стрелата върху таблото, като за всяко улучено поле,
            //той получава определен брой точки.Всяко поле има по три сектора: единичен(Single) сектор от който се взимат броят точки от полето.Двоен(Double),
            //от него се взимат удвоените точки от полето и троен(Triple) сектор, точките от който са умножени по 3.
            //Получените точки от всеки изстрел се изваждат от началните точки, до достигане на 0.
            //Забележка: При изстрел, даващ повече точки от наличните, той се зачита за неуспешен и играчът трябва да хвърля отново,
            //докато не уцели точки равни на оставащите или по-малки, такъв удар се счита за успешен.
            //Пример: При налични точки 100, удар даващ повече от 100 точки, неуспешен
            //При налични точки 100, удар даващ по - малко или равни на 100 точки, успешен
            //  Вход
            //Първоначално се чете един ред:
            //•	Името на играча - текст
            //След това до получаване на команда "Retire" се четат многократно по два реда:
            //1.Поле – текст("Single", "Double" или "Triple")
            //2.Точки – цяло число в интервала[0… 100]
            //Изход
            //Играта приключва при въвеждане на команда "Retire" или при изравняване на началните 301 точки към 0.На конзолата трябва да се напечата един ред:
            //•	Ако играчът е спечелил лега:
            //            o   "{името на играча} won the leg with {успешните изстрели} shots."
            //•	Ако играчът се е отказал от играта:
            //            o   "{името на играча} retired after {неуспешни изстрели} unsuccessful shots."
            string namePlayer = Console.ReadLine();
            string field = Console.ReadLine();
            int totalPoints = 301;
            int counter = 0;
            int unsuccessful = 0;
            while (field!= "Retire")
            {
                int total = 0;
                int points = int.Parse(Console.ReadLine());
                if (totalPoints>0)
                {

                }
                {
                    counter++;
                    switch (field)
                    {
                        case "Single":
                            total += points;
                            break;
                        case "Double":
                            total += points * 2;
                            break;
                        case "Triple":
                            total += points * 3;
                            break;

                    }
                    if (totalPoints>=total)
                    {
                        totalPoints -= total;
                    }
                    else
                    {
                        unsuccessful++;
                    }
                if (totalPoints==0)
                {
                    Console.WriteLine($"{namePlayer} won the leg with {counter-unsuccessful} shots.");
                    return;
                }
                }
                field = Console.ReadLine();
            }
            if (field== "Retire")
            {
                Console.WriteLine($"{namePlayer} retired after {unsuccessful} unsuccessful shots.");
            }
        }
    }
}
