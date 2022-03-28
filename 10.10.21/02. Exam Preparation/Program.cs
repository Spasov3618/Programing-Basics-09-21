using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Ако Марин стигне до командата "Enough", отпечатайте на 3 реда:
            //            o   "Average score: {средна оценка}"
            //o   "Number of problems: {броя на всички задачи}"
            //o   "Last problem: {името на последната задача}"
            //•	Ако получи определеният брой незадоволителни оценки:
            //o   "You need a break, {брой незадоволителни оценки} poor grades."
            //Средната оценка да бъде форматирана до втория знак след десетичната запетая


            int numFousNeed = int.Parse(Console.ReadLine());
            int numFous = 0;
            double evaluation = 0;
            int numExam = 0;
            string lastname = "";
            string name = Console.ReadLine();
            double evaluatienNow = double.Parse(Console.ReadLine());
            while (name != "Enough")
            {
                numExam++;
                evaluation += evaluatienNow;
                lastname = name;

                if (evaluatienNow <= 4)
                {
                    numFous++;
                    if (numFous == numFousNeed)
                    {
                        Console.WriteLine($"You need a break, {numFous} poor grades.");

                        break;

                    }
                }
            name = Console.ReadLine();

                if (name == "Enough")
                {
                    double averageScore = 1.0 * evaluation / numExam;
                    Console.WriteLine($"Average score: {averageScore:f2}");
                    Console.WriteLine($"Number of problems: {numExam}");
                    Console.WriteLine($"Last problem: {lastname}");
                    break;
                }

               evaluatienNow = double.Parse(Console.ReadLine());
            }
        }
    }
}
