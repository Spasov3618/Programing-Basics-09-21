using System;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} | {0}", new string(' ', n));
            int spaces = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1} | {1}{0}", new string(' ', n - i), new string('*', spaces));
                spaces++;
            }
        }
    }
}
