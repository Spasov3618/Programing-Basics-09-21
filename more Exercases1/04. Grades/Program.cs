using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //            От конзолата се четат поредица от числа, всяко на отделен ред:
            //•	На първия ред – броя на студентите явили се на изпит – цяло число в интервала[1...1000]
            //•	За всеки един студент на отделен ред – оценката от изпита – реално число в интервала[2.00...6.00]
            //Изход
            //Да се отпечатат на конзолата 5 реда, които съдържат следната информация:
            //Ред 1 - "Top students: {процент студенти с успех 5.00 или повече}%"
            //Ред 2 - "Between 4.00 and 4.99: {между 4.00 и 4.99 включително}%"
            //Ред 3 - "Between 3.00 and 3.99: {между 3.00 и 3.99 включително}%"
            //Ред 4 - "Fail: {по-малко от 3.00}%"
            //Ред 5 - "Average: {среден успех}"
            //Всички числа трябва да са форматирани до вторият знак след десетичната запетая.
            double numStudents = double.Parse(Console.ReadLine());
            double counter5 = 0;
            double counter4 = 0;
            double counter3 = 0;
            double counter2 = 0;
            double average = 0;
            for (int i = 0; i < numStudents; i++)
            {
                double evaluation = double.Parse(Console.ReadLine());
                if (evaluation >= 5)
                {
                    counter5 ++;
                }
                else if (evaluation >= 4 && evaluation < 5)
                {
                    counter4 ++;
                }
                else if (evaluation >= 3 && evaluation < 4)
                {
                    counter3 ++ ;
                }
                else if (evaluation < 3)
                {
                    counter2 ++;
                }
                average += evaluation;
            }
            double percent5 = counter5 / numStudents  * 100;
            double percent4 = counter4 / numStudents  * 100;
            double percent3 = counter3 / numStudents  * 100;
            double percent2 = counter2 / numStudents  * 100;
            double percentAverage = average / numStudents;
            Console.WriteLine($"Top students: {percent5:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percent4:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percent3:f2}%");
            Console.WriteLine($"Fail: {percent2:f2}%");
            Console.WriteLine($"Average: {percentAverage:f2}");
        }
    }
}
