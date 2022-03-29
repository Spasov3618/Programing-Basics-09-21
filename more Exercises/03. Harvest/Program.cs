using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Желаното количество вино за продан е Z литра.
            //Напишете програма, която пресмята колко вино може да се произведе и дали това количество е достатъчно.
            //Ако е достатъчно, остатъкът се разделя по равно между работниците на лозето.
            
            //•	Ако произведеното вино е колкото или повече от нужното:
            // “Good harvest this year! Total wine: { общо вино} liters.”
            //	Резултатът трябва да е закръглен към по - ниско цяло число
            //o   “{ Оставащо вино} liters left -> { вино за 1 работник} liters per person.”
            //	И двата резултата трябва да са закръглени към по - високото цяло число

            double squareMeters = double.Parse(Console.ReadLine());
            double extraction = double.Parse(Console.ReadLine());
            double wineForSale = double.Parse(Console.ReadLine());
            double numWorking = double.Parse(Console.ReadLine());
            double totalExtraction = squareMeters * extraction;
            double totalWine = (totalExtraction * 0.4) / 2.5;
            if (totalWine <wineForSale )
            {
                double different = wineForSale - totalWine;
                Console.WriteLine($"It will be a tough winter! More {Math .Floor (different)} liters wine needed.");
            }
            else
            {
                double left = totalWine - wineForSale;
                double personal = left / numWorking;

                Console.WriteLine($"Good harvest this year! Total wine: {Math .Floor (totalWine) } liters.");
                Console.WriteLine($"{Math.Ceiling (left)} liters left -> {Math .Ceiling (personal) } liters per person.");
            } 
        }
    }
}
