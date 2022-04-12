using System;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете цяло положително число n,
            //    въведено от потребителя, и чертае на конзолата квадратна рамка с размер n* n като в примерите по-долу:

            //•	Отпечатайте горната част: знак “+”, n - 2 пъти знак “-”, знак “+”.
            //•	Отпечатайте средната част: в цикъл n - 2 пъти печатайте знак “|”, n - 2 пъти знак “-”, знак “|”.
            //•	Отпечатайте долната част: знак “+”, n - 2 пъти знак “-”, знак “+”.
            int num = int.Parse(Console.ReadLine());
                    Console.Write("+ ");
            for (int i = 0; i < num - 2; i++)
            {
                Console.Write("- ");
            }
                Console.Write("+");
            
            Console.WriteLine();
            for (int l = 0; l < num - 2; l++)
            {
                Console.Write("| ");

                for (int k = 0; k < num - 2; k++)
                {
                    Console.Write("- ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            
            
            Console.Write("+ ");
            for (int j = 0; j < num - 2; j++)
            {
                Console.Write("- ");
            }
                Console.Write("+");
            

        }
    }
}
