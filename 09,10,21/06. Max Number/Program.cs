using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Напишете програма, която до получаване на командата "Stop", чете цели числа, 
            //    въведени от потребителя и намира най-голямото измежду тях. Въвежда се по едно число на ред.
            string num = Console.ReadLine();
            int max = int.MinValue;
            while (num != "Stop")
            {
                int nowNum = int.Parse(num);
                num = Console.ReadLine();
                if (max < nowNum)
                {
                    max = nowNum;
                }
            }
                Console.WriteLine(max);
           
        }
    }
}
