using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Напишете програма, която изчислява средната оценка на ученик от цялото му обучение.На първия ред ще получите името на ученика,
            //    а на всеки следващ ред неговите годишни оценки.Ученикът преминава в следващия клас, ако годишната му оценка е по-голяма или
            //   равна на 4.00.Ако ученикът бъде скъсан повече от един път, то той бива изключен и програмата приключва, като се отпечатва името на ученика
            //   и в кой клас бива изключен.
            // При успешно завършване на 12 - ти клас да се отпечата : 
            //"{име на ученика} graduated. Average grade: {средната оценка от цялото обучение}"
            //В случай, че ученикът е изключен от училище, да се отпечата:
            //   "{име на ученика} has been excluded at {класа, в който е бил изключен} grade"
            //Стойността трябва да бъде форматирана до втория знак след десетичната запетая.
            string name = Console.ReadLine();
            double klas = 1;
            double totalAssessment = 0;
            double num = 0;
            while (klas <= 12)
            {
                double annualAssessment = double.Parse(Console.ReadLine());

                if (annualAssessment < 4)
                {
                    
                    num++;
                    if (num == 2)
                    {
                     Console.WriteLine($"{name} has been excluded at {klas} grade");
                     break;
                    }
                    continue;
                }
                klas++;
                totalAssessment += annualAssessment;
            }

        
                double averageSuccess = totalAssessment / 12;
            if (klas > 12)
            {


                Console.WriteLine($"{name} graduated. Average grade: {averageSuccess:f2}");
            }
        }
    }
}
