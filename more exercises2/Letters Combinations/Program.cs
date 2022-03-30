using System;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char toSkip = char.Parse(Console.ReadLine());

            int combinations = 0;

            for (char firstLetter = start; firstLetter <= end; firstLetter++)
            {
                for (char secondLetter = start; secondLetter <= end; secondLetter++)
                {
                    for (char thirdLetter = start; thirdLetter <= end; thirdLetter++)
                    {
                        if (firstLetter != toSkip && secondLetter != toSkip && thirdLetter != toSkip)
                        {
                            Console.Write(" {0}{1}{2}", firstLetter, secondLetter, thirdLetter);
                            combinations++;
                        }
                    }
                }
            }

            Console.WriteLine(" {0}", combinations);
        }
    }
}
