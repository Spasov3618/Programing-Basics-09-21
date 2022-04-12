﻿using System;

namespace Movie_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Трябва да напишете програма, която чете три цели числа  a1, a2, n въведени от потребителя и генерира номера за билети, които се състоят от следните 4 символа:
            //•	Символ 1: символ с ASCII код от а1 до а2 -1
            //•	Символ 2: цифра от 1 до n -1
            //•	Символ 3: цифра от 1 до n / 2 - 1
            //•	Символ 4: цифрова репрезентация(ASCII код) на символ 1
            //След като са изпълнени условията се генерира следния билет:
            //            "{Символ 1}-{Символ 2}{Символ 3}{Символ  4}"
            //Вход
            //•	a1 – цяло число в интервала[65… 89]
            //•	a2 – цяло число в интервала[66… 91]
            //•	n – цяло число в интервала[1… 10]
            //Изход
            //На конзолата трябва да се отпечатат всички билетни номера, на които числовата репрезентация на символ 1 е нечетна и сборът на символ 2, символ 3 и символ 4 е нечетен.
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = a1; i <= a2-1 ; i++)
            {
                char one = (char)i;
    
                for (int j  = 1; j <=n-1; j ++)
                {
                    for (int k = 1; k <= n / 2 - 1; k++)
                    {
                        if (i % 2 == 1 && (j + k + i) % 2 == 1)
                        {
                            Console.WriteLine($"{one}-{j}{k}{i}");
                        }
                    }
                }
            }
        }
    }
}