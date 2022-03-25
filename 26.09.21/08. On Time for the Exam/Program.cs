using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minArrive = int.Parse(Console.ReadLine());

            int difference = 0;
            int hours = 0;
            int minutes = 0;

            minExam += hourExam * 60;
            minArrive += hourArrive * 60;

            if (minArrive > minExam)
            {
                Console.WriteLine("Late");
                difference = minArrive - minExam;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start.");
                }
                else
                {
                    hours = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }

            }
            else if (minArrive < minExam - 30)
            {
                Console.WriteLine("Early");
                difference = minExam - minArrive;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hours = difference / 60;
                    minutes = difference % 60;

                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                difference = minExam - minArrive;
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
    }
}
