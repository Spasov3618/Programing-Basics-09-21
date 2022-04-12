using System;

namespace Rectangle_of_N_x_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете цяло положително число n, въведено от потребителя, и печата на конзолата правоъгълник от n* n звездички.
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num ; i++)
            {
                for (int j = 0; j < num ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
