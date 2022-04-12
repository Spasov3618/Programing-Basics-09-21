using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int star = 2 * n;
            int space = n;
            int dash = 2 * n - 2;
            Console.WriteLine("{0}{1}{0}",
                new string('*', star),
                new string(' ', space)
                );
            for (int i = 0; i < n - 2; i++)
            {
                if (i == (n - 1) / 2 - 1)
                {
                    Console.WriteLine("*{0}*{1}*{0}*",
                    new string('/', dash),
                    new string('|', space)
                    );
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*",
                    new string('/', dash),
                    new string(' ', space)
                    );
                }
            }
            Console.WriteLine("{0}{1}{0}",
                new string('*', star),
                new string(' ', space)
                );
        }
        //**********     **********
        //*////////*     *////////*
        //*////////*|||||*////////*
        //*////////*     *////////*
        //**********     **********
    }


    }
