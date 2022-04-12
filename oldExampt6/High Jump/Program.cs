﻿using System;

namespace High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            //Българският лекоатлет Тихомир Иванов започва тренировки за предстоящото европейско първенство по лека атлетика на закрито в Глазгоу, Шотландия.
            //Вашата задача е да напишете софтуер, с който Иванов да следи своя прогрес и дали е достигнал желаните резултати.
            //В началото програмата получава желаната височина на летвата от Тихомир, той започва тренировката си като поставя летвата на височина 30см по-ниско от целта.
            //За всяка височина той има право на 3 скока, като за да бъде един скок успешен, той трябва да бъде над височината на летвата. При успешен скок(над летвата),
            //височината й се вдига с 5 сантиметра.При три неуспешни скока на една и съща височина, тренировката приключва с неуспех.
            //При достигане на желаната височина и нейното успешно прескачане, тренировката приключва с успех.
            //Вход
            //Входът е поредица от цели числа в интервала[100…300]:
            //•	На първия ред се прочита желаната от Тихомир Иванов височина в сантиметри
            //•	На всеки следващ ред до приключване на програмата се прочита височината от скока на Иванов
            //Изход
            //На конзолата трябва да се отпечата един ред:
            //•	Ако Тихомир не успее да преодолее желаната височина:
            //o   "Tihomir failed at {височина на летвата към момента на провала}cm after {брой скокове от началото на тренировката} jumps."
            //•	Ако Тихомир успее да преодолее височината:
            //o   "Tihomir succeeded, he jumped over {височина на прескочената последно летва}cm after {брой скокове за цялата тренировка} jumps."
            int height = int.Parse(Console.ReadLine());
            int startHeight = height - 30;
            int counterJumped = 0;
            int counterNo = 0;
            int counteroll = 0;
            bool flag = false;
            int newJumpd = int.Parse (Console.ReadLine());
            while (startHeight<=height )
            {

                for (int i = 1; i <= 3; i++)
            {

                    if (newJumpd > startHeight)
                    {
                        counterJumped++;
                        counterNo = 0;
                        counteroll++;
                        flag = true;
                        break;
                    }
                   else if (newJumpd<=startHeight)
                    {
                        counterNo++;
                        counteroll++;
                        if (counterNo==3)
                        {
                        Console.WriteLine($"Tihomir failed at {startHeight}cm after {counteroll} jumps.");
                            return;
                        }
                        else
                        {

                      newJumpd = int.Parse(Console.ReadLine());
                        }
                    }

                }
            if (startHeight>=height)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {height}cm after {counteroll} jumps.");
                    return;
            }
                if (flag)
                {
                    startHeight += 5;
                    newJumpd = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
