using System;

namespace The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            //За Лора думите притежават голяма сила. Тя те моли да измислиш алгоритъм, с който да откриеш коя е "най-силната" дума.
            //До получаване на команда "End of words" ще се четат от конзолата думи. За да се открие силата на всяка една,
            //трябва да се намери сборът от ASCII стойностите на символите, от които се състои думата.
            //Ако започва с гласна буква - 'a', 'e', 'i', 'o', 'u', 'y'(или техните еквивалентни главни букви),
            //полученият сбор трябва да се умножи по дължината на думата, в противен случай, да се раздели на дължината и да се закръгли до най-близкото цяло число надолу.
            //Вход
            //До получаване на команда "End of words" се чете по един ред от конзолата:
            //•	дума – текст
            //Изход
            //След приключване на програмата се печата на един ред думата с "най-голяма сила":
            //•	"The most powerful word is {думата с най-голяма сила} - {силата на думата}"

            string word = Console.ReadLine();
            double bestWord = 0;
            string best = "";
            while (word != "End of words")
            {
                double sumWord = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    char sum = word[i];
                    sumWord += sum;
                }

                char input = word[0];
                if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u' || input == 'y'||input=='A'|| input=='E'|| input=='I'||input=='O'||input =='U'||input=='Y')
                {
                    sumWord *= word.Length;
                }
                else
                {
                    Math.Floor(sumWord /= word.Length);
                }

                if (bestWord <= sumWord)
                {
                    bestWord = sumWord;
                    best = word;
                }
            
                word = Console.ReadLine();
            }
            if (word== "End of words")
            Console.WriteLine($"The most powerful word is {best} - {bestWord}");
        }
    }
}
