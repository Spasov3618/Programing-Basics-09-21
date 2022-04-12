using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Докато не получите "Старт", ще ви бъдат дадени различни монети, които се поставят в машината. Трябва да ги сумирате, за да вкарате общите пари. Все пак има проблем.
            //Вашият автомат работи само с 0,1, 0,2, 0,5, 1 и 2 монети.Ако някой се опита да вмъкне други монети, трябва да покажете „Cannot accept { money}“ и да не го добавите към общите пари.
            //На следващите няколко реда, докато не получите "Край", ще ви бъдат дадени продукти за закупуване.Вашата машина обаче има само "ядки", "вода", "чипсове", "сода", "кола".Цените са съответно: 2.0, 0.7, 1.5, 0.8, 1.0.Ако лицето се опита да закупи несъществуващ продукт, отпечатайте „Невалиден продукт“.
            //Внимавайте човекът да се опита да закупи продукт, за който няма пари.В такъв случай отпечатайте „Съжалявам, няма достатъчно пари“. Ако лицето закупи продукт успешно, отпечатайте „Закупено { product name}“.
            //След командата "Край" отпечатайте парите, които са останали форматирани до втората десетична запетая във формат "Промяна: {пари останаха}".
            string money = Console.ReadLine();
            double sum = 0;
            while (money != "Start")
            {
                double input = double.Parse(money);
                if (input == 0.1 || input == 0.2 || input == 0.5 || input == 1 || input == 2)
                {
                    sum += input;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                money = Console.ReadLine();
            }
            if (money == "Start")
            {
                string produkt = Console.ReadLine();
                // "Nuts", "Water", "Crisps", "Soda", "Coke"
                while (produkt != "End")
                {

                    if (produkt == "Nuts" || produkt == "Water" || produkt == "Crisps" || produkt == "Soda" || produkt == "Coke")
                    {

                        switch (produkt)
                        {
                            case "Nuts":
                                if (sum >= 2)
                                {
                                    Console.WriteLine("Purchased nuts");
                                    sum -= 2;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                break;
                            case "Water":
                                if (sum >= 0.7)
                                {
                                    Console.WriteLine("Purchased water");
                                    sum -= 0.7;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                break;
                            case "Crisps":
                                if (sum >= 1.5)
                                {
                                    Console.WriteLine("Purchased crisps");
                                    sum -= 1.5;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                break;
                            case "Soda":
                                if (sum >= 0.8)
                                {
                                    Console.WriteLine("Purchased soda");
                                    sum -= 0.8;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");

                                }
                                break;
                            case "Coke":
                                if (sum >= 1)
                                {
                                    Console.WriteLine("Purchased coke");
                                    sum -= 1;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                break;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid product");
                    }
                    produkt = Console.ReadLine();
                }



                if (produkt == "End")
                {
                    Console.WriteLine($"Change: {sum:f2}");
                }
            
        
                
            }
        }
    }
}
