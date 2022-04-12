using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Ще ви бъде дадено потребителско име. Паролата ще бъде обърнатото потребителско име.
            //Докато не получите правилната парола, отпечатайте на конзолата:
            //  „Неправилна парола. Опитайте отново.“
            //  Когато получите правилната парола, отпечатайте:
            //  „Потребителят { username}
            //            влезе в системата.“
            //Въпреки това, при четвъртия опит, ако паролата все още не е правилна, отпечатайте:
            //„Потребителят { username}
            //            е блокиран!“
            //След това програмата спира
            string username = Console.ReadLine ();
            string password = "";
            for (int i = username.Length-1  ; i >= 0; i--)
            {
                password += username[i];
            }
            for (int i = 1; i <= 4; i++)
            {
                string input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else if (input!=password)
                {
                    if (i==4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        return;
                    }
                    else
                    {

                    Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }
           
        }
    }
}
