using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ще ви бъде дадено цяло число и трябва да отпечатате на конзолата дали това число се дели на следните числа: 2, 3, 6, 7, 10.Винаги трябва да вземете по-голямото деление.
            //Ако числото се дели и на 2, и на 3, то също се дели на 6 и трябва да отпечатате само делението на 6.Ако числото се дели на 2, то понякога също се дели на 10 и трябва да отпечатате делението на 10.Ако числото не се дели на нито едно от дадените числа отпечатайте „Не се дели“. В противен случай отпечатайте „Числото се дели на { число}“. 
            int num = int.Parse(Console.ReadLine());
            if (num %10 ==0)
            {
                Console.WriteLine("The number is divisible by 10");
                return;
            }
            else if (num%7 ==0)
            {
                Console.WriteLine("The number is divisible by 7");
                return;
            }
            else if (num %6 ==0)
            {
                Console.WriteLine("The number is divisible by 6");
                return;
            }
            else if (num%3 ==0)
            {
                Console.WriteLine("The number is divisible by 3");
                return;
            }
            else if (num %2 ==0)
            {
                Console.WriteLine("The number is divisible by 2");
                return;
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
