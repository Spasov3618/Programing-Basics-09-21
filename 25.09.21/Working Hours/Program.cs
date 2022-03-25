using System;

namespace _07.WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            double hours = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            if (hours >= 10 && hours <= 18)
            {
                if (dayOfWeek == "Monday")

                {
                    Console.WriteLine("open");
                }
                if (dayOfWeek == "Tuesday")
                {
                    Console.WriteLine("open");
                }
                if (dayOfWeek == "Wednesday")
                {
                    Console.WriteLine("open");
                }
                if (dayOfWeek == "Thursday")
                {
                    Console.WriteLine("open");
                }
                if (dayOfWeek == "Friday")
                {
                    Console.WriteLine("open");

                }
                if (dayOfWeek == "Saturday")
                {
                    Console.WriteLine("open");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }


            if (dayOfWeek == "Sunday")
            {
                Console.WriteLine("closed");
            }
        }
    }
}