using System;

namespace The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            //Паролата има формат: "abcd" и контролната стойност трябва да е равна на  a* b +c * d , но трябва да бъдат спазени следните условия:
            //при намирането на а и b: a < b
            //при намиране на c и d: c > d
            //a, b, c и d са числа в интервала[1 - 9]
            //Каруцата има четири колела, затова паролата ще е четвърто число, което трябва да се отпечата.
            //В случай, че НЕ се намери такова число,  отпечатва се „No!“.

            //Вход
            //От конзолата се чете едно цяло число(контролната стойност): M – цяло число в интервала[4 … 144];
            // Изход
            //Отпечатването на конзолата зависи от резултата:
            //Ако са намерени четворки числа(аbcd), отговарящи на условието, ги отпечатваме всичките с разделител интервал: “
            //{ а}
            //{ b}
            //{ c}
            //{ d} ”
            //•	Отпечатва се един от двата реда на нов ред:
            //•	Ако съществува четвърта четворка се отпечатва: „Password: { а}
            // { b}
            // { c}
            //{ d}“
            //•	Ако НЕ са намерени такива числа или няма  четвърта четворка отпечатваме: “No!”
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            int password1 = 0;
            int password2 = 0;
            int password3 = 0;
            int password4 = 0;
            for (int a = 1; a <=9; a++)
            {
                for (int b = 1; b <=9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a * b + c * d == num && a < b && c > d)
                            {
                                counter++;
                                Console.Write($"{a}{b}{c}{d} ");

                                if (counter == 4)
                                {
                                    password1 = a;
                                    password2 = b;
                                    password3 = c;
                                    password4 = d;

                                }
                            }
                        }
                    }
                }
            }
            if (counter<4)
            {
                Console.WriteLine();
            Console.WriteLine("No!");
            }
            else
            {
            Console.WriteLine();
            Console.WriteLine($"Password: {password1}{password2}{password3}{password4}");
            }
            
        }
    }
}
