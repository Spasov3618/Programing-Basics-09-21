using System;

namespace Movie_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Счетоводителят на киноцентър "Тинтява 15" ви наема да напишете програма, която пресмята хонорарите за актьорите.
            //Всяка продукция има бюджет за актьори. До команда "ACTION" ще получавате име на актьор и възнаграждението му.
            //Ако името на актьора е по-дълго от 15 символа възнаграждението му ще е 20 % от останалия бюджет до момента.
            //Ако бюджета в даден момент свърши, програмата трябва да прекъсне.
            //Вход
            //От конзолата първо се чете един ред:
            //•	Бюджет за актьори - реално число в интервала[1000.0... 2 100 000.0]
            //След това се четат многократно по един или два реда до команда "ACTION" или до изчерпване на бюджета:
            //•	Име на актьор - текст
            //Ако името на актьора съдържа по-малко или равно на 15 брой символи: 
            //o Възнаграждение -реално число в интервала[250.0… 1 000 000.0]
            //Изход
            //На конзолата да се отпечата един ред:
            //•	Ако бюджета е достатъчен :
            //             "We are left with {останал бюджет} leva."
            //•	Ако бюджета не е достатъчен:
            //            "We need {необходим бюджет} leva for our actors."
            //Резултата да се форматира до втората цифра след десетичния знак!
            double budjet = double.Parse(Console.ReadLine());
            double zaplata = 0;
            string name = Console.ReadLine();
            while (name!= "ACTION")
            {
                double input = name.Length;
                if (input >15)
                {
                    zaplata = budjet * 0.2;
                    budjet -= zaplata;
                }
                else
                {
                    double zapl = double.Parse(Console.ReadLine());
                    budjet -= zapl;
                }
                if (budjet <= 0)
                {
                    break;
                }
                name = Console.ReadLine();
            }
            if (budjet >=0)
            {
                Console.WriteLine($"We are left with {budjet:f2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {Math.Abs(budjet):f2} leva for our actors.");
            }
        }
    }
}
