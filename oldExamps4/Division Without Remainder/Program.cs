using System;

namespace Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дадени са n цели числа в интервала[1…1000].От тях някакъв процент p1 се делят без остатък на 2, друг процент p2 се делят без остатък на 3, 
            //    друг процент p3 се делят без остатък на 4.Да се напише програма, която изчислява и отпечатва процентите p1, p2 и p3.
            //            На първия ред от входа стои цялото число n(1 ≤ n ≤ 1000) – брой числа. 
            //На следващите n - на брой реда стои по едно цяло число в интервала[1…1000] – числата които да бъдат проверени на колко се делят.
            //Изход
            //Да се отпечатат на конзолата 3 реда, всеки от които съдържа процент между 0 % и 100 %, с точност две цифри след десетичната точка, например 25.00 %, 66.67 %, 57.14 %.
            //•	На първият ред – процентът на числата които се делят на 2
            //•	На вторият ред – процентът на числата които се делят на 3
            //•	На третият ред – процентът на числата които се делят на 4
            double num = double.Parse(Console.ReadLine());
            double counterp1 = 0;
            double counterp2 = 0;
            double counterp3 = 0;
            for (int i = 1; i <= num; i++)
            {
                double n = double.Parse(Console.ReadLine());
                if (n %2 == 0)
                {
                    counterp1++;
                }
                if (n%3 ==0)
                {
                    counterp2++;

                }
                if (n%4==0)
                {
                    counterp3++;
                }
            }
            double percentP1 = counterp1 / num * 100;
            double percentP2 = counterp2 / num * 100;
            double percentP3 = counterp3 / num * 100;
            Console.WriteLine($"{percentP1:f2}%");
            Console.WriteLine($"{percentP2:f2}%");
            Console.WriteLine($"{percentP3:f2}%");
        }
    }
}
