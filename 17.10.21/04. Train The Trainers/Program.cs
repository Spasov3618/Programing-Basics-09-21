﻿using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Курсът "Train the trainers" е към края си и финалното оценяване наближава. Вашата задача е да помогнете на
            //журито което ще оценява презентациите, като напишете програма в която да изчислява средната оценка от представянето на 
            //всяка една презентация от даден студент, а накрая средният успех от всички тях.
            //От конзолата на първият ред се прочита броят на хората в журито n - цяло число в интервала[1…20]
            //След това на отделен ред се прочита името на презентацията -текст
            //За всяка една презентация на нов ред се четат n -на брой оценки -реално число в интервала[2.00…6.00]
            //След изчисляване на средната оценка за конкретна презентация, на конзолата се печата
            // "{името на презентацията} - {средна оценка}."
            //След получаване на команда "Finish" на конзолата се печата "Student's final assessment is {среден успех от всички презентации}."
            //и програмата приключва.
            //Всички оценки трябва да бъдат форматирани до втория знак след десетичната запетая.

            double numOfJuri = double.Parse(Console.ReadLine());
            double ollNumEvaluation = 0;
            double ollNum = 0;
           
            string nameOfPrezentetion = Console.ReadLine();
            while (nameOfPrezentetion != "Finish")
            {
                double ollEvaluation = 0;
                double numEvaluation = 0;

                for (int i = 1; i <= numOfJuri; i++)
                {
                    double evaluation = double.Parse(Console.ReadLine());
                    ollEvaluation += evaluation;
                    numEvaluation++;
                    ollNumEvaluation++;
                    ollNum += evaluation;


                }
                {
                    double average = ollEvaluation / numEvaluation;
                    Console.WriteLine($"{nameOfPrezentetion} - {average:f2}.");
                    nameOfPrezentetion = Console.ReadLine();
                }
            }
                double ollAverage = ollNum / ollNumEvaluation;
                Console.WriteLine($"Student's final assessment is {ollAverage:f2}.");
            
            
        }
    }
}
