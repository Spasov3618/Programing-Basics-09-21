using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
                     
            double  holiday = double .Parse(Console.ReadLine());
            double  sleep = 30000;
            double  workingDay = (365 - holiday) * 63;
            double  holidayPlay = holiday * 127;
            double totalplay = workingDay + holidayPlay;
            double yarsPlay = totalplay - sleep;
            double hours = yarsPlay / 60;
            double minutes = yarsPlay % 60;
            if (totalplay  > sleep  )
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math .Floor (hours)} hours and {minutes} minutes more for play") ;
            }
            else
            {
                double yarsPlaymore = sleep - totalplay;
                double hours1 = yarsPlaymore / 60;
                double minutes1 = yarsPlaymore % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math .Floor (hours1)} hours and {minutes1} minutes less for play");
            }

        }
    }
}
