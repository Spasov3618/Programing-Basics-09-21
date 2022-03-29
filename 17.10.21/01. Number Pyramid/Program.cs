using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 1;
            bool isBiger = false;
          
            for (int rows = 1; rows <= num; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)

                {
                    if (counter > num)
                    {
                        isBiger = true;
                        break;
                    }
                    Console.Write(counter + " ");
                    counter++;
                }
                    if (isBiger)
                    {
                        break;
                    }
                
                    Console.WriteLine();
            }
        }
    }
}
