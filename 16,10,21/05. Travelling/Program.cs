using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double money = double.Parse(Console.ReadLine());
                double counter = 0;
                while (counter  < money )
                {
                    double moneuSave = double.Parse(Console.ReadLine());
                    counter += moneuSave;
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
