using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ще получите три реда от конзолата:
            //• Брой хора, които отиват на почивка.
            //• Тип на групата(Студентски, Бизнес или Редовна).
            //• Денят от седмицата, в който групата ще остане(петък, събота или неделя).
            //Въз основа на предоставената информация изчислете колко ще плати групата за цялата ваканция.
            //Цената за един човек е както следва:
            //              петък              събота              неделя
            //Ученици        8.45                9.80               10.46
            //Бизнес        10.90              15.60                16
            //Редовна         15                20                  22,50
            //Има и отстъпки въз основа на някои условия:
            //• Студенти – ако групата е по-голяма или равна на 30 човека трябва да намалите общата цена с 15 %
            //• Бизнес – ако групата е по-голяма или равна на 100 души, 10 от тях могат да останат безплатно.
            //• Редовна – ако групата е по-голяма или равна на 10 и по-малка или равна на 20 намалете общата цена с 5 %
            //Забележка: Трябва да намалите цените в ТОЧНИЯ ред!
            //Като изход отпечатайте крайната цена, която групата ще плати във формат:
            //„Обща цена: { price}“
            //Цената трябва да бъде форматирана до втория десетичен знак.
            //•	Type of the group(Students, Business, or Regular).
            //•	 The day of the week which the group will stay(Friday, Saturday, or Sunday).

            int numPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double totalPrice = 0;
            switch (typeGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            totalPrice = numPeople * 8.45;
                            break;
                        case "Saturday":
                            totalPrice = numPeople * 9.80;
                            break;
                        case "Sunday":
                            totalPrice = numPeople * 10.46;
                            break;
                    }
                    if (numPeople >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Business":
                    if (numPeople >= 100)
                    {
                        numPeople -= 10;
                    }
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            totalPrice = numPeople * 10.90;
                            break;
                        case "Saturday":
                            totalPrice = numPeople * 15.60;
                            break;
                        case "Sunday":
                            totalPrice = numPeople * 16;
                            break;
                    }
                    break;

                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            totalPrice = numPeople * 15;
                            break;
                        case "Saturday":
                            totalPrice = numPeople * 20;
                            break;
                        case "Sunday":
                            totalPrice = numPeople * 22.50;
                            break;
                    }
                    if (numPeople>=10 && numPeople<=20)
                    {
                        totalPrice *= 0.95;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
