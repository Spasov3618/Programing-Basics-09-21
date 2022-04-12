using System;

namespace Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Предстои Великден и едно от най-вълнуващите неща е боядисването на яйца.Наличните цветове за боядисване са:
            //•	червено(red)
            //•	оранжев(orange)
            //•	син(blue)
            //•	зелен(green)
            //Напишете програма, която изчислява какъв е броят на яйцата от всеки цвят и от кой цвят яйцата са най -много, като знаете общия им брой и цвета на всяко яйце.
            //Вход
            //От конзолата се чете 1 ред:
            //•	 Броят на боядисаните яйца – цяло число в интервала[1... 100]
            //За всяко яйце се чете:
            //            o Цветът на яйцето – текст с възможности: "red", "orange", "blue", "green"
            //Изход
            //Да се отпечатат на конзолата 5 реда:
            //•	"Red eggs: {брой на червените яйца}"
            //•	"Orange eggs: {брой на оранжевите яйца}"
            //•	"Blue eggs: {брой на сините яйца}"
            //•	"Green eggs: {брой на зелените яйца}"
            //•	"Max eggs: {максимален брой на яйцата от цвят} -> {цвят}"
            int numEggs = int.Parse(Console.ReadLine());
            int counterRed = 0;
            int counterOrange = 0;
            int counterBlue = 0;
            int counterGreen = 0;
            int maxColor = 0;
            string colorMax = "";
            for (int i = 1; i <= numEggs; i++)
            {
                string color = Console.ReadLine();
                if (color == "red")
                {
                    counterRed++;
                }
                else if (color == "orange")
                {
                    counterOrange++;
                }
                else if (color == "blue")
                {
                    counterBlue++;
                }
                else if (color == "green")
                {
                    counterGreen++;
                }
            }
            if (counterRed > maxColor)
            {
                maxColor = counterRed;
                colorMax = "red";
            }
            if (counterOrange > maxColor)
            {
                maxColor = counterOrange;
                colorMax = "orange";
            }
            if (counterBlue > maxColor)
            {
                maxColor = counterBlue;
                colorMax = "blue";
            }
            if (counterGreen > maxColor)
            {
                maxColor = counterGreen;
                colorMax = "green";
            }
            Console.WriteLine($"Red eggs: {counterRed}");           
            Console.WriteLine($"Orange eggs: {counterOrange}");           
            Console.WriteLine($"Blue eggs: {counterBlue}");           
            Console.WriteLine($"Green eggs: {counterGreen}");           
            Console.WriteLine($"Max eggs: {maxColor} -> {colorMax}");           
        }
    }
}
