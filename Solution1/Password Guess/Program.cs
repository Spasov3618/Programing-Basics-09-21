using System;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "s3cr3t!P@ssw0rd";
        string pass = Console.ReadLine();
           if (pass == password)
              Console.WriteLine("Welcome");
           else
                Console.WriteLine("Wrong password!");
        }

    }
}
