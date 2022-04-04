using System;

namespace Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	при добавен мобилен интернет, към таксата за един месец се добавя:
            //o при такса по-малка или равна на 10.00 лв.  5.50 лв.
            //o при такса по-малка или равна на 30.00 лв.  4.35 лв.
            //o при такса по-голяма от 30.00 лв.  3.85 лв.
            //•	ако договорът e за две години, общата сума се намалява с 3.75 %
                   
            string srok =Console.ReadLine();
            string tip = Console.ReadLine();
            string net = Console.ReadLine();
            double numMonths = double.Parse(Console.ReadLine());
            double total = 0;
            if (srok == "one")

                switch (tip)
                {
                    case "Small":
                        total = 9.98;
                        break;
                    case "Middle":
                        total = 18.99;
                        break;
                    case "Large":
                        total = 25.98;
                        break;
                    case "ExtraLarge":
                        total = 35.99;
                        break;

                }
            else if (srok == "two")
            {
                switch (tip)
                {
                    case "Small":
                        total = 8.58;
                        break;
                    case "Middle":
                        total = 17.09;
                        break;
                    case "Large":
                        total = 23.59;
                        break;
                    case "ExtraLarge":
                        total = 31.79;
                        break;
                }
            }
            if (net =="yes")
            {
                if (total <=10)
                {
                    total += 5.50;
                }
                else if (total >=10 && total<=30)
                {
                    total += 4.35;
                }
                else if (total>30)
                {
                    total += 3.85;
                }
            }
            total *= numMonths;
            if (srok == "two")
            {
                total *= 0.9625;
            }
            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
