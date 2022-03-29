using System;

namespace _08._Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата число r и пресмята и отпечатва лицето и периметъра на кръг / окръжност с радиус r,
            //като форматирате изхода в следния вид: "<calculated area>"
            //"<calculated parameter>".Форматирайте изходните данни до втория знак след десетичната запетая.
            double r = double.Parse(Console.ReadLine());
            double calculatedarea = Math.PI * r *r;
            double calculatedparametar = 2 * Math.PI * r;
            Console.WriteLine($"{calculatedarea:f2}");
            Console.WriteLine($"{calculatedparametar:f2}");
            
            
            
            //Примерен вход и изход
            //вход изход
            //3   28.27
            //18.85
            //4.5 63.62
            //28.27

        }
    }
}
