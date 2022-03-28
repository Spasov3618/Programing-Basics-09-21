using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string nameBook = Console.ReadLine();
            int num = 0;
            string name = Console.ReadLine();
            while (name != "No More Books")
            {
                if (name == nameBook)
                {
                    Console.WriteLine($"You checked {num} books and found it.");
                    break;
                }
             num++;
                name = Console.ReadLine();
            }
            if (name == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {num} books.");
            }
        }
    }
}
