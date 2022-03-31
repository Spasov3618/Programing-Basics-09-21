using System;

namespace Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която ви помага при товаренето на куфари в багажника на самолет.
            //Всеки самолет има определен капацитет на багажника.До получаване на команда "End" ще получавате обем на куфар.
            //Обемът на всеки трети куфар трябва да се увеличава с 10 %, поради загубата на пространство при начина на подреждане
            //. Ако свободното пространството в даден момент е по-малко от обема на куфар товаренето трябва да прекъсне.
            //Вход
            //Първоначално се чете един ред:
            //•	Капацитетът на багажника – реално число в диапазона[100.0…6000.0]
            //След това до получаване на команда "End" или до запълване на багажника, се чете по един ред:
            //o Обем на куфар – реално число в диапазона[100.0…6000.0]
            //Изход
            //На конзолата да се отпечатат следните редове според случая:
            //•	При получаване на командата "End" се печата:
            //"Congratulations! All suitcases are loaded!"
            //•	Ако обемът на куфара е по-голям от оставащото пространство в багажника:
            //"No more space!"
            //•	Накрая винаги се отпечатва статистика – колко багажа са натоварени:
            //"Statistic: {брой натоварени багажи} suitcases loaded."
            double bagaj = double.Parse(Console.ReadLine());
            double counter = 0;
            double total = 0;
            string switcase = Console.ReadLine();
            while (switcase != "End")
            {
                double input = double.Parse(switcase);
                total += input;
                if (total < bagaj)
                {
                    counter++;
                }
                if (total >= bagaj)
                             
                {
                    Console.WriteLine("No more space!");
                    break;

                }
                    switcase = Console.ReadLine();
                
            }
            if (switcase == "End")
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
