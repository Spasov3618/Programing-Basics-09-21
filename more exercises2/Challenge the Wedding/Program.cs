using System;

namespace Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMen = int.Parse(Console.ReadLine());
            int numWomen = int.Parse(Console.ReadLine());
            int numTable = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= numMen; i++)
            {
                for (int j = 1; j <= numWomen; j++)
                {
                    Console.Write($"({i} <-> {j}) ");
                    counter++;
                    if (counter == numTable)
                    {
                        break;
                    }
                }
                if (counter == numTable)
                {
                    break;
                }
            }
        }
    }
}
