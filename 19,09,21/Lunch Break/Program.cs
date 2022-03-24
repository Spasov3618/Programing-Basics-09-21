using System;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int timeSerial = int.Parse(Console.ReadLine());
            double  timeRelax = double .Parse(Console.ReadLine());
            double timeLunch = timeRelax / 8;
            double timeRest = timeRelax / 4;
            double timeLeft = timeRelax - (timeLunch + timeRest);
            double freetime = Math .Abs  (timeSerial - timeLeft);
            if (timeLeft >= timeSerial)
            {
             Console.WriteLine($"You have enough time to watch {serial } and left with {Math .Ceiling ( freetime)} minutes free time.");
            }
            else
            {
               Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math .Ceiling (freetime)} more minutes.");
               
            }
        }
    }
}
