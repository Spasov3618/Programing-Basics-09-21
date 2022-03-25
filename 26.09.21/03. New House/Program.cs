using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            const double roza = 5;
            const double Dalia = 3.80;
            const double Lili = 2.80;
            const double Narcis = 3;
            const double Gladiola = 2.50;
            string flouers = Console.ReadLine();
            double nomber = double.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());
            //•	Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %
            double moneu = 0;
            switch (flouers)
            {
                case "Roses":
                    {
                        if (nomber > 80)
                            moneu -= roza * nomber * 0.1;
                    }
                        moneu += nomber * roza;
                    break;
                       
                    
                case "Dahlias":
                    {
                if (nomber > 90)
                    moneu -= Dalia * nomber * 0.15;
                    } 
                            moneu += Dalia * nomber ;
                break;
                    
                case "Tulips":
                    {
                        if (nomber > 80)
                            moneu -= Lili * nomber * 0.15;
                    }
                            moneu += Lili * nomber;
                        break;
                    
                case "Narcissus":
                    {
                        if (nomber < 120)
                            moneu += Narcis * nomber * 0.15;
                    }
                            moneu += Narcis * nomber;
                        break;
                    
                case "Gladiolus":
                    {
                        if (nomber < 80)

                            moneu += Gladiola * nomber * 0.20;
                        
                            moneu += Gladiola * nomber;
                        break;
                    }
            }
            if (moneu <= budjet)
            {
                double leftMoneu = budjet - moneu;


                Console.WriteLine($"Hey, you have a great garden with {nomber} {flouers} and {leftMoneu:f2} leva left.");
            }
            else
            {
                double monneNeed = moneu - budjet;
                Console.WriteLine($"Not enough money, you need {monneNeed:f2} leva more.");
                //            •	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
                //•	Ако бюджета им е НЕ достатъчен -"Not enough money, you need {нужната сума} leva more."

            }


        }
    }
}
