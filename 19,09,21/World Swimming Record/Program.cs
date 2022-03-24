using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse( Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            double timeIvan = distance * time;
            double delay = Math .Floor ( distance / 15);
            double delayIvan = delay * 12.5;
            double totalTimeIvan = timeIvan + delayIvan;
            
            if (record <= totalTimeIvan)
            {
                double difference = totalTimeIvan - record;
                Console.WriteLine($"No, he failed! He was {difference:f2} seconds slower.");
            }
            else 
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTimeIvan:f2} seconds.");

            }


        }
    }
}
