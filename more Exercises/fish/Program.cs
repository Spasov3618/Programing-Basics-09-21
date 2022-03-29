using System;

namespace fish
{
    class Program
    {
        static void Main(string[] args)
        {

            //	Паламуд – 60 % по - скъп от скумрията
            //•	Сафрид – 80 % по - скъп от цацата
            //•	Миди – 7.50 лв.за килограм
            double priceSkum = double.Parse(Console.ReadLine());
            double priceCaca = double.Parse(Console.ReadLine());
            double kiloPalamud = double.Parse(Console.ReadLine());
            double kiloSafrid = double.Parse(Console.ReadLine());
            double kiloMidi = double.Parse(Console.ReadLine());
            double pricePalamud = ((priceSkum *0.6 + priceSkum) * kiloPalamud) ;
            double priceSafrid = ((priceCaca *0.8 + priceCaca) * kiloSafrid);
            double priceMidi = kiloMidi * 7.5;
            double total = pricePalamud + priceSafrid + priceMidi;
            Console.WriteLine($"{ total:f2}");
          
            //Да се отпечата на конзолата едно число с плаваща запетая: колко пари ще са нужни на Георги, за да си плати сметката.
            //                Числото трябва да е форматирано до вторият знак след десетичната запетая(1.2457-> 1.25).
            
        }
        
    }
}
