using System;

namespace Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {

            int firsDoubleStart = int.Parse(Console.ReadLine());
            int secondDoubleStart = int.Parse(Console.ReadLine());
            int firsDoubleLenght = int.Parse(Console.ReadLine());
            int secondDoubleLenght = int.Parse(Console.ReadLine());


                for (int first = firsDoubleStart; first <= firsDoubleStart + firsDoubleLenght; first++)
                {
                    for (int second = secondDoubleStart; second <= secondDoubleStart + secondDoubleLenght; second++)
                    {
                       

                        bool firstCheck = true;
                        for (int n = 2; n <= Math.Floor(Math.Sqrt(first)); n++)
                        {
                            if (first % n == 0)
                            {
                                firstCheck = false;
                            }
                        }

                        bool secondCheck = true;
                        for (int m = 2; m <= Math.Floor(Math.Sqrt(second)); m++)
                        {
                            if (second % m == 0)
                            {
                                secondCheck = false;
                            }
                        }

                        if (firstCheck && secondCheck)
                        {
                            Console.WriteLine("{0}{1}", first, second);
                        }


                    }
                }


            }
        }
}
