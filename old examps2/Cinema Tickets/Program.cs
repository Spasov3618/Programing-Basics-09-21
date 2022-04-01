using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Вашата задача е да напишете програма, която да изчислява процента на билетите за всеки тип от продадените билети: студентски(student), стандартен(standard) и детски(kid), за всички прожекции.Трябва да изчислите и колко процента от залата е запълнена за всяка една прожекция.
            //Вход
            //Входът е поредица от цели числа и текст:
            //•	На първия ред до получаване на командата "Finish" - име на филма – текст
            //•	На втори ред – свободните места в салона за всяка прожекция – цяло число[1 … 100]
            //•	За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване на командата "End":
            //o Типа на закупения билет - текст("student", "standard", "kid")
            //Изход
            //На конзолата трябва да се печатат следните редове:
            //•	След всеки филм да се отпечата, колко процента от кино залата е пълна
            //"{името на филма} - {процент запълненост на залата}% full."
            //•	При получаване на командата "Finish" да се отпечатат четири реда:
            //            o   "Total tickets: {общият брой закупени билети за всички филми}"
            //o   "{процент на студентските билети}% student tickets."
            //o   "{процент на стандартните билети}% standard tickets."
            //o   "{процент на детските билети}% kids tickets."
            string nameMovie = Console.ReadLine();
            int counterStudents = 0;
            int counterStandard = 0;
            int counterKids = 0;
            int totalPlaces = 0;
            int ollPlaces = 0;
            while (nameMovie != "Finish")
            {
                int freePlaces = int.Parse(Console.ReadLine());
                int students = 0;
                int standart = 0;
                int kids = 0;

                string tipTicket = Console.ReadLine();
               while (tipTicket != "End")
                {
                    switch (tipTicket)
                    {
                        case "student":
                            students++;
                            counterStudents++;
                            break;
                        case "standard":
                            standart++;
                            counterStandard++;
                            break;
                        case "kid":
                            kids++;
                            counterKids++;
                            break;
                    }
                    totalPlaces = students + standart + kids;
                    if (freePlaces < totalPlaces)
                    {
                        break;
                    }
                    tipTicket = Console.ReadLine();

                }
                if (tipTicket == "End" || freePlaces>=totalPlaces )
                {



                    double percentMovie = 1.0 * totalPlaces / freePlaces * 100;
                    ollPlaces += totalPlaces;
                    totalPlaces = 0;
                    Console.WriteLine($"{nameMovie} - {percentMovie:f2}% full.");
                }
                    nameMovie = Console.ReadLine();
                

        }
        Console.WriteLine($"Total tickets: {ollPlaces}");
            double percentStudents = 1.0 * counterStudents / ollPlaces * 100;
        double percentStandart = 1.0 * counterStandard / ollPlaces * 100;
        double percentKids = 1.0 * counterKids / ollPlaces * 100;
        Console.WriteLine($"{percentStudents:f2}% student tickets.");
            Console.WriteLine($"{percentStandart:f2}% standard tickets.");
            Console.WriteLine($"{percentKids:f2}% kids tickets.");
            
        }
    }
}
