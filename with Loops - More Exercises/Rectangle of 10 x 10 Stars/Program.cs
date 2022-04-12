using System;

namespace Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Напишете програма, която чертае на конзолата правоъгълник от 10 x 10 звездички.
            //Примерен вход и изход
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {

                Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
