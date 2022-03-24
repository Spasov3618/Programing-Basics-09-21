using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Петър иска да купи N видеокарти, M процесора и P на брой рам памет.Ако броя на видеокартите е по-голям от този на процесорите получава 15 % отстъпка от крайната сметка.Важат следните цени:
            const int videoCard = 250;
            //•	Видеокарта – 250 лв./ бр.
            double budjet = double.Parse(Console.ReadLine());
            int videoCardPc = int.Parse(Console.ReadLine());
            int procesorsPc = int.Parse(Console.ReadLine());
            int ramMemoryPc = int.Parse(Console.ReadLine());
            double priseVideoCard = videoCardPc * videoCard;
            double priseProcesors = (videoCardPc * videoCard) * 0.35;
            double totalSumProcesor = procesorsPc * priseProcesors;
            double priseRamMemory = (videoCardPc * videoCard) * 0.10;
            double totalPriseRamMemory = priseRamMemory * ramMemoryPc;
            double totalPrise = priseVideoCard + totalSumProcesor + totalPriseRamMemory;
            if (videoCardPc > procesorsPc)
            {
                totalPrise *= 0.85;
            }
            if (budjet >= totalPrise)
            {
                double totalbudjet = budjet - totalPrise;
                Console.WriteLine($"You have {totalbudjet:f2} leva left!");
            }
            else
            {
                double needmoney = totalPrise - budjet;
                Console.WriteLine($"Not enough money! You need {needmoney:f2} leva more!");
            }
      

        }
    }
}
