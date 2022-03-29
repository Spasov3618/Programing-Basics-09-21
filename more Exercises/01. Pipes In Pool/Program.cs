using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            double pool = double.Parse(Console.ReadLine());
            double debitPipeOne = double.Parse(Console.ReadLine());
            double debitPipeTwo = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double firstPipe = debitPipeOne * hours;
            double secondPipe = debitPipeTwo * hours;
            double totalPool = firstPipe + secondPipe;
            double total = totalPool / pool * 100;
            double percent1 = (firstPipe / totalPool )*100;
            double percent2 = (secondPipe / totalPool)*100;
            if (pool >= totalPool)
            {
                Console.WriteLine($"The pool is {total:f2}% full. Pipe 1: {percent1:f2}%. Pipe 2: {percent2:f2}%.");
            }
            else 
            {
                double razlika = totalPool - pool;
                Console.WriteLine($"For {hours} hours the pool overflows with {razlika:f2} liters.");
            }
        }
    }
}
