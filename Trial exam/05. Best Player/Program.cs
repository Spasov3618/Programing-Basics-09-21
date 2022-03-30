using System;

namespace _05._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePlayer = Console.ReadLine();
            int veryGools = 0;
           
            string bestPlayer = "";
            while (namePlayer != "END")
            {
                int numGools = int.Parse(Console.ReadLine());
                if (veryGools < numGools)
                {
                    veryGools = numGools;
                    bestPlayer = namePlayer;
               
                }
                if (numGools >= 10)
                {
                    break;
                }
                namePlayer = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (veryGools >=3)
            {
                Console.WriteLine($"He has scored {veryGools} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {veryGools} goals.");
            }



        }
    }
}
