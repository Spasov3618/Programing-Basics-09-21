using System;

namespace _04._Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            double numStudents = double.Parse(Console.ReadLine());
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;
            double totalEvaluation = 0;
            for (int i = 1; i <= numStudents; i++)
            {
                double evaluation = double.Parse(Console.ReadLine());
                if (evaluation >=2 && evaluation <=2.99)
                {
                    counter1++;
                    totalEvaluation += evaluation;
                }
                else if (evaluation >=3 && evaluation <=3.99)
                {
                    counter2++;
                    totalEvaluation += evaluation;
                }
                else if (evaluation >=4 && evaluation<=4.99)
                {
                    counter3++;
                    totalEvaluation += evaluation;
                }
                else if (evaluation>=5)
                {
                    counter4++;
                    totalEvaluation += evaluation;
                }
            }
            //Изход:
            //Да се отпечатат на конзолата 5 реда, които съдържат следната информация:
            //Ред 1 - "Top students: {процент студенти с успех 5.00 или повече}%"
            //Ред 2 - "Between 4.00 and 4.99: {между 4.00 и 4.99 включително}%"
            //Ред 3 - "Between 3.00 and 3.99: {между 3.00 и 3.99 включително}%"
            //Ред 4 - "Fail: {по-малко от 3.00}%"
            //Ред 5 - "Average: {среден успех}"
            //Всички числа трябва да са форматирани до втория знак след десетичната запетая.
            double percent1 = counter1 / numStudents * 100;
            double percent2 = counter2 / numStudents *100 ;
            double percent3 = counter3 / numStudents*100;
            double percent4 = counter4 / numStudents*100;
            double average = totalEvaluation / numStudents;
            Console.WriteLine($"Top students: {percent4:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percent3:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percent2:f2}%");
            Console.WriteLine($"Fail: {percent1:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
