using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int start = n;
            int counter = 0;
            while (n>=m)
            {
                n -= m;
                counter++;

                if (start/2==n&& y!=0)
                {
                    n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(counter);
        }
    }
}
