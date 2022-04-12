using System;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n ; i++)
            {
                for (int f = 1; f <=n; f++)
                {
                    for (char k = 'a'; k <'a'+ l; k++)
                    {
                        for (char j = 'a'; j < 'a' + l; j++)
                        {
                            for (int m = Math.Max(i,f)+1; m <=n ; m++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i, f, k, j,m);                            }
                        }
                            
                    }

                }
            }
        }
    }
}
