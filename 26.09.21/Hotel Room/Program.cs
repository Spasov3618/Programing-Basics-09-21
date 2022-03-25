using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            const double maiOktoberPriceStudio = 50;
            const double maiOktoberPriceApartment = 65;
            const double juneSeptemberPriceStudio = 75.20;
            const double juneSeptemberPriceApartment = 68.70;
            const double julayAugustPriceApartment = 77;
            const double julayAugustPriceStudio = 76;

            string mesec = Console.ReadLine();
            int nomberDay = int.Parse(Console.ReadLine());
            double priseStudio = 0;
            double priseApartment = 0;
            //•	За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
            //•	За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
            //•	За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
            //•	За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.
            switch (mesec)
            {
                case "May":
                case "October":
                    priseStudio = maiOktoberPriceStudio * nomberDay;
                    priseApartment = maiOktoberPriceApartment * nomberDay;
                    if (nomberDay > 7 && nomberDay < 14)
                    {
                        priseStudio -= priseStudio * 0.05;
                    }
                    else if (nomberDay > 14)
                    {
                        priseStudio -= priseStudio * 0.3;
                    }

                    break;
                case "June":
                case "September":
                    priseStudio = nomberDay * juneSeptemberPriceStudio;
                    priseApartment = juneSeptemberPriceApartment * nomberDay;
                    if (nomberDay > 14)
                    {
                        priseStudio -= priseStudio * 0.2;
                    }
                    break;
                case "July":
                case "August":
                    priseApartment = julayAugustPriceApartment  * nomberDay;
                    priseStudio = julayAugustPriceStudio  * nomberDay;
                    break;
            }
                    if (nomberDay > 14)
                    {
                     priseApartment -= priseApartment * 0.1;
                    }
            Console.WriteLine($"Apartment: {priseApartment :f2} lv." );
            Console.WriteLine($"Studio: {priseStudio :f2} lv.");
            
        }
    }
}
