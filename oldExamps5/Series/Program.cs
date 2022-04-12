using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            //От телевизионна компания ви наемат да създадете програма, която да изчислява дали за клиентите ще е възможно да си закупят желаните сериали.
            //Разполагате с бюджет и брой сериали, които потребителят ще желае да закупи.Всеки сериал съответно има заглавие и цена.
            //Някои от сериалите имат намаление:
            //•	Thrones – 50 %
            //•	Lucifer – 40 %
            //•	Protector – 30 %
            //•	TotalDrama – 20 %
            //•	Area – 10 %
            
            //Изход
            //На конзолата да се изпише един ред:
            //•	Ако бюджета ви е по - голям или равен на цената на сериалите:
            //	"You bought all the series and left with {останали пари} lv."
            //•	Ако бюджета ви е по - малък от цената на сериалите:
            //	"You need {нужни пари} lv. more to buy the series!"
            //Резултатът да бъде закръглен до втората цифра след десетичния знак.
            double budjet = double.Parse(Console.ReadLine());
            double total = 0;
            double numSerial = double.Parse(Console.ReadLine());
            for (int i = 1; i <=numSerial; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                if (name!= "Thrones" && name!= "Lucifer" && name != "Protector" && name != "TotalDrama" && name!= "Area")
                {

                total += price; 
                }
                switch (name)
                {
                    case "Thrones":
                        total += price * 0.5;
                        break;
                    case "Lucifer":
                        total += price * 0.6;
                            break;
                    case "Protector":
                        total += price * 0.7;
                        break;
                    case "TotalDrama":
                        total += price * 0.8;
                        break;
                    case "Area":
                        total += price * 0.9;
                        break;
                }
            }
            if (budjet>= total)
            {
                double left = budjet - total;
                Console.WriteLine($"You bought all the series and left with {left:f2} lv.");
            }
            else
            {
                double need = total - budjet;
                Console.WriteLine($"You need {need:f2} lv. more to buy the series!");
            }
        }
    }
}
