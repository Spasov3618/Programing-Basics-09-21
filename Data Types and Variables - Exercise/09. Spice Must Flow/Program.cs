using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            //В ден 1 извличаме 111 подправки и в края на смяната работниците консумират 26, оставяйки 85. Добивът пада с 10 до 101.
            //На 2-ри ден извличаме 101 подправки, работниците консумират 26, остават 75. Общо 160, а добивът падна до 91.
            //Тъй като очакваната доходност е по-малка от 100, ние изоставяме източника. Работниците вземат още 26, остават 134. Мината работи 2 дни. 
            int start = int.Parse(Console.ReadLine());
            int dobiv = 0;
            int consume = 26;
            int counter = 0;
            while (start>=100)
            {
                dobiv += start;
                counter++;
                start -= 10;
                if (dobiv>=consume)
                {

                dobiv -= consume;
                }
                else
                {
                    dobiv -= dobiv;
                }
            }
            if (dobiv>=consume)
            {

            dobiv -= consume;
            }
            else
            {
                dobiv -= dobiv;

            }
            Console.WriteLine(counter);
            Console.WriteLine(dobiv);
        }
    }
}
