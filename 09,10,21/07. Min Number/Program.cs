using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int max = int.MaxValue;
            while (num != "Stop")
            {
                int nowNum = int.Parse(num);
                num = Console.ReadLine();
                if (max > nowNum)
                {
                    max = nowNum;
                }
            }
            Console.WriteLine(max);
        }
    }
}
