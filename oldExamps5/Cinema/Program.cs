using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //От кино ви наемат да напишете програма, чрез която да разберете дали на една прожекцията ще се запълни залата и колко пари ще се изкарат от нея.
            //Получавате места в залата и на всеки следващ ред до команда "Movie time!", колко хора влизат в залата.Цената на един билет е 5 лв
            //.Ако текущия брой хора влезли в залата се дели на 3 без остатък, се прави отстъпка 5лв от общата им сметка.
            //Ако в залата се опитат да влязат повече хора от колкото места са останали, то се счита че местата са изчерпани и програмата трябва да приключи четенето на вход.
            //Вход
            //От конзолата се четат:
            //•	На първия ред - капацитет на залата -цяло число в интервала[50... 150]
            //На всеки следващ ред до команда "Movie time!":
            //o Брой хора влизащи в киното -цяло число в интервала[1… 15]
            //Изход
            //На конзолата първо да се отпечата един ред:
            //•	При получена команда "Movie time!":
            // "There are {останали места} seats left in the cinema."
            //•	При изчерпване на местата в залата:
            //	"The cinema is full."
            //След това да се отпечата:
            //            "Cinema income - {приходи от залата} lv."
            double numPlaces = double.Parse(Console.ReadLine());
            double counter = 0;
            double total = 0;
            string numPeople = Console.ReadLine();
            while (numPeople != "Movie time!")
            {

                double input = double.Parse(numPeople);
                counter += input;
                if (counter > numPlaces)
                {
                    
                    break;
                }
                if (input % 3 == 0)
                {
                    total += (input * 5) - 5;
                }
                else
                {
                    total += input * 5;
                }
                numPeople = Console.ReadLine();


            }
        
                if (numPeople == "Movie time!" || counter == numPlaces)
                {
                 double left = numPlaces - counter;
        Console.WriteLine($"There are {left} seats left in the cinema.");
                }
            else if (counter>numPlaces)
            {
                Console.WriteLine("The cinema is full."); 
            }
            Console.WriteLine($"Cinema income - {total} lv.");
        }
    }
}
