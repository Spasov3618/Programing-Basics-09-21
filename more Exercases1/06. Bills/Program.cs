using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Напишете програма която да пресмята средният разход за месец на семейство за даден период време.За всеки месец
            //            разходите са следните:
            //•	За ток – всеки месец е различен, ще се чете от конзолата
            //•	за вода – 20 лв.
            //•	за интернет – 15 лв.
            //•	за други – събират се тока, водата и интернета за месеца и към сумата се прибавят 20 %.
            //За всеки разход трябва да се пресметне колко общо е платено за всички месеци.
            //Вход
            //Входът се чете от конзолата:
            //•	Първи ред – месеците за които се търси средният разход – цяло число в интервала[1...100]
            //•	За всеки месец – сметката за ток – реално число в интервала[1.00...1000.00]
            //Изход
            //Да се отпечата на конзолата 5 реда:
            //•	1ви ред: "Electricity: {ток за всички месеци} lv"
            //•	2ри ред: "Water: {вода за всички месеци} lv"
            //•	3ти ред: "Internet: {интернет за всички месеци} lv"
            //•	4ти ред: "Other: {други за всички месеци} lv"
            //•	5ти ред: "Average: {средно всички разходи за месец} lv"
            //Всички числа трябва да са форматирана до вторият знак след запетаята.
            double maunths = double.Parse(Console.ReadLine());
            const double water = 20;
            const double net = 15;
            double allAnader = 0;
            double allElectricity = 0;
            for (int i = 0; i < maunths; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                double all = (electricity + water + net);
                double anadar = (all * 0.2) + all;
                allAnader += anadar;
                allElectricity += electricity;
            }
            double allWater = water * maunths;
            double allNet = net * maunths;
            double total = (allAnader + allElectricity + allNet + allWater) / maunths;
            Console.WriteLine($"Electricity: {allElectricity:f2} lv");
            Console.WriteLine($"Water: {allWater:f2} lv");
            Console.WriteLine($"Internet: {allNet:f2} lv");
            Console.WriteLine($"Other: {allAnader:f2} lv");
            Console.WriteLine($"Average: {total:f2} lv");
        }
    }
}
