using System;

namespace Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ще получите две цели числа от конзолата.Първото число е началото на поредицата, второто число е краят на поредицата.Вашата задача е да отпечатате два реда:
            //• На първия ред отпечатайте всички числа от началото на поредицата до края, включително
            //• На втория ред отпечатайте сумата от последователността във формат: "Sum: {sum}"
            int numStart = int.Parse(Console.ReadLine());
            int numStop = int.Parse (Console.ReadLine());
            int sum = 0;
            for (int i = numStart; i <= numStop; i++)
            {
                Console.Write(i +" ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
