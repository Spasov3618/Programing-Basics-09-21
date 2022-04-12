using System;

namespace Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            //На Великден семейството на Деси се събира и тя решава да организира "битка" между великденски яйца.
            //Правилата на "битката" са следните:
            //•	Участват двама играчи
            //•	Всеки от тях започва с определен брой яйца
            //•	При получаване на команда "one"->първият играч печели => яйцата на втория намаляват с едно 
            //•	При получаване на команда "two"->вторият играч печели => яйцата на първия намаляват с едно
            //•	Играта приключва, ако някой от играчите остане без яйца или до получаване на команда "End of battle"
            //Вход
            //Първоначално се четат два реда:
            //1.Брой яйца, които има първият играч -цяло число в интервала[1 … 99]
            //2.Брой яйца, които има вторият играч -цяло число в интервала[1 … 99]
            //След това до получаване на команда "End of battle" се четe многократно един ред:
            //3.Победител - текст - "one" или "two"
            //Изход
            //Ако първият играч остане без яйца:
            //•	"Player one is out of eggs. Player two has {брой останали яйца на втория играч} eggs left."
            //Ако вторият играч остане без яйца:
            //•	"Player two is out of eggs. Player one has {брой останали яйца на първия играч} eggs left."
            //При команда "End of battle" да се отпечатат два реда:
            //•	"Player one has {брой останали яйца на първия играч} eggs left."
            //•	"Player two has {брой останали яйца на втория играч} eggs left."
            int numEggsOne = int.Parse(Console.ReadLine());
            int numEggsTwo = int.Parse(Console.ReadLine());
            int counterOne = numEggsOne;
            int counterTwo = numEggsTwo;
            string winner = Console.ReadLine();
            while (winner!= "End of battle")
            {
                if (winner == "one")
                {
                    
                    counterTwo--;
                }
                else if (winner== "two")
                {
                   
                    counterOne--;
                }
                if (counterOne == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {counterTwo} eggs left.");
                    return;
                }
                if (counterTwo==0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {counterOne} eggs left.");
                    return;
                }
                winner = Console.ReadLine();
            }
            if (winner== "End of battle")
            {
                Console.WriteLine($"Player one has {counterOne} eggs left.");
                Console.WriteLine($"Player two has {counterTwo} eggs left.");
            }
        }
    }
}
