using System;

namespace Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вие сте режисьор на филма "Програмирането е забавно", като имате определено време за снимки.
            //От вас се иска да напишете програма, с която ще разберете дали снимачният ден ще ви стигне да заснемете филма.
            //Снимачният ден започва с подготовка на терен, което е 15 процента от времето за снимки! Филмът има определен брой сцени, които се заснемат за определено време.
            //Вход
            //От конзолата се четат 3 реда:
            //1.Време за снимки – цяло число в диапазона[0… 1440]
            //2.Брой сцени  – цяло число в диапазона[5… 25]
            //3.Времетраене на сцена – цяло число в диапазона[20… 90]
            //Изход
            //На конзолата да се отпечата един ред:
            //•	Ако времето за заснемане на филма ви стигне: 
            //  "You managed to finish the movie on time! You have {останало време} minutes left!"
            //•	Ако времето НЕ ВИ стигне:
            //            "Time is up! To complete the movie you need {нужно време} minutes."
            //Останалото време да се закръгли до най - близкото цяло число.
            double timeFoto = double.Parse(Console.ReadLine());
            double sceni = double.Parse(Console.ReadLine());
            double timeScena = double.Parse(Console.ReadLine());
            double podgotovka = timeFoto * 0.15;
            double total = sceni * timeScena + podgotovka;
            if (timeFoto>= total)
            {
                double left = timeFoto - total;
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round( left)} minutes left!");
            }
            else
            {
                double need = total - timeFoto;
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(need)} minutes.");    
            }
        }
    }
}
