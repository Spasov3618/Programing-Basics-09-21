using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Магазин за цветя предлага 3 вида цветя: хризантеми, рози и лалета.Цените зависят от сезона.
            //Сезон             Хризантеми         Рози              Лалета
            //Пролет / Лято      2.00 лв./ бр.     4.10 лв./ бр.    2.50 лв./ бр.
            //Есен / Зима        3.75 лв./ бр.     4.50 лв./ бр.    4.15 лв./ бр.
            //В празнични дни цените на всички цветя се увеличават с 15 %.Предлагат се следните отстъпки:
            //•	За закупени повече от 7 лалета през пролетта – 5 % от цената на целият букет.
            //•	За закупени 10 или повече рози през зимата – 10 % от цената на целият букет.
            //•	За закупени повече от 20 цветя общо през всички сезони – 20 % от цената на целият букет.
            //Отстъпките се правят по така написания ред и могат да се наслагват!Всички отстъпки важат след оскъпяването за празничен ден!
            //Цената за аранжиране на букета винаги е 2лв.Напишете програма, която изчислява цената за един букет.
           
            //•	На петия ред е посочено дали денят е празник – [Y – да / N - не]
            //Изход
            //Да се отпечата на конзолата 1 число – цената на цветята, форматирана до вторият знак след десетичната запетая.
            double numHrizantemi = double.Parse(Console.ReadLine());
            double numRozi = double.Parse(Console.ReadLine());
            double numLaleta = double.Parse(Console.ReadLine());
            string seson = Console.ReadLine();
            string day = Console.ReadLine();
            double priceHrizantemi = 0;
            double priceRozi = 0;
            double priceLalete = 0;
            double total = 0;
            switch (seson)
            {
                case "Spring":
                    priceHrizantemi = numHrizantemi * 2;
                    priceRozi = numRozi * 4.10;
                    priceLalete = numLaleta * 2.50;
                    total = priceHrizantemi + priceRozi + priceLalete;
                    if (day == "Y")
                    {
                        total *= 1.15;
                    }
                    if (numLaleta > 7)
                    {
                        total *= 0.95;
                    }
                    break;
                case "Summer":
                    priceHrizantemi = numHrizantemi * 2;
                    priceRozi = numRozi * 4.10;
                    priceLalete = numLaleta * 2.50;
                    total = priceHrizantemi + priceRozi + priceLalete;
                    if (day == "Y")
                    {
                        total *= 1.15;
                    }
                    break;
                case "Autumn":
                    priceHrizantemi = numHrizantemi * 3.75;
                    priceRozi = numRozi * 4.50;
                    priceLalete = numLaleta * 4.15;
                    total = priceHrizantemi + priceRozi + priceLalete;
                    if (day == "Y")
                    {
                        total *= 1.15;
                    }
                    break;
                case "Winter":
                    priceHrizantemi = numHrizantemi * 3.75;
                    priceRozi = numRozi * 4.50;
                    priceLalete = numLaleta * 4.15;
                    total = priceHrizantemi + priceRozi + priceLalete;
                    if (day == "Y")
                    {
                        total *= 1.15;
                    }
                    if (numRozi >= 10)
                    {
                        total *= 0.90;
                    }
                    break;
            }
            if (numHrizantemi+numRozi+numLaleta >20)
            {
                total *= 0.8;
            }
            total += 2;
            Console.WriteLine($"{total:f2}");
            }
    }
}
