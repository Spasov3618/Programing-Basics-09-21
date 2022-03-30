using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Иван искал да си купи няколко части за неговия компютър и отишъл в магазин.
            //Понеже там нямало частите в наличност, те трябвало да ги поръчат.
            //Той искал да си купи процесор, видео карта и RAM памет, като за процесора и видео картата магазинът му прави няколко процента отстъпка.
            //Всичко трябвало да плати в долари, затова трябва цените да се обърнат в лева, като приемем, че 1 долар = 1.57 лева.
            //Да се напише програма, която пресмята колко общо пари ще му трябват в лева, за да може да си закупи частите.
            //Вход
            //От конзолата се прочитат 5 реда:
            //•	На първи ред: цената в долари за процесора – реално число в интервала[200.00 … 3000.00]
            //•	На втори ред: цената в долари за видео карта – реално число в интервала[100.00 … 1500.00]
            //•	На трети ред: цената в долари за една RAM памет – реално число в интервала[80.00... 500.00]
            //•	На четвърти: ред брой RAM памети – цяло число в интервала[1... 4]
            //•   На пети ред: процент отстъпка – реално число в интервала[0.01 … 0.1]
            //Изход
            //Да се отпечата на конзолата на един ред:
            //•   Колко общо лева ще му трябват, за да си закупи частите. 
            //   "Money needed - {общо лева} leva."
            //Сумата трябва да се форматира до втория знак след десетичната запетая.
            double priceProcesor = double.Parse(Console.ReadLine());
            double priceVideoMaps = double.Parse(Console.ReadLine());
            double priceRamMemory = double.Parse(Console.ReadLine());
            int numRamMemory = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double priceProcesorLv = priceProcesor * 1.57;
            double priceVideoMapsLv = priceVideoMaps * 1.57;
            double priceRamMemoryLv = priceRamMemory * 1.57 * numRamMemory;
            double totalPriceProcesor = priceProcesorLv - (priceProcesorLv * discount);
            double totalPriceVideoMaps = priceVideoMapsLv - (priceVideoMapsLv * discount);
            double totalPrice = priceRamMemoryLv + totalPriceProcesor + totalPriceVideoMaps;
            Console.WriteLine($"Money needed - {totalPrice:f2} leva.");

        }
    }
}
