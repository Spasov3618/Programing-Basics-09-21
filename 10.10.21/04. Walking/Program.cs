using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Габи иска да започне здравословен начин на живот и си е поставила за цел да върви 10 000 стъпки всеки ден.
            //Някои дни обаче е много уморена от работа и ще иска да се прибере преди да постигне целта си.
            //Напишете програма, която чете от конзолата по колко стъпки изминава тя всеки път като излиза през деня и когато постигне целта си
            // да се изписва "Goal reached! Good job!"  и колко стъпки повече е извървяла "{разликата между стъпките} steps over the goal!"
            //Ако иска да се прибере преди това, тя ще въведе командата "Going home" и ще въведе стъпките, които е извървяла докато се прибира.
            //След което, ако не е успяла да постигне целта си, на конзолата трябва да се изпише:
            //"{разликата между стъпките} more steps to reach goal."
            const int goSteps = 10000;
            int totalSteps = 0;
            while (totalSteps <goSteps )
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int stepLeft = int.Parse(Console.ReadLine());
                    totalSteps += stepLeft;
                    break;
                }
                int curentSteps = int.Parse(input);
                totalSteps += curentSteps;
            }
            if (totalSteps >=goSteps )
            {
                Console.WriteLine("Goal reached! Good job!");
                int total = totalSteps - goSteps;
                Console.WriteLine($"{total} steps over the goal!");
            }
            else
            {
                int overtotal = goSteps - totalSteps;
                Console.WriteLine($"{overtotal} more steps to reach goal.");
            }

        }
    }
}
