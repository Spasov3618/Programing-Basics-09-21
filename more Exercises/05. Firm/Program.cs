using System;

namespace _05._Firm
{
    class Program
    {
        static void Main(string[] args)
        {

            //Проектът може да бъде завършен на време и остават 2 часа.
            int hoursProjegt = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int numPerson = int.Parse(Console.ReadLine());
            double workingHours = (day * 0.9) * 8;
            double extraHours = (day * numPerson) * 2;
            double ollHours = workingHours + extraHours;
            //            •	Ако времето е достатъчно:
            //o   “Yes!{ оставащите часове} hours left.”
            if (ollHours >=hoursProjegt )
            {
                double different = ollHours - hoursProjegt;
                Console.WriteLine($"Yes!{Math .Round (different)} hours left.");
            }
            else
            {
                double different1 = hoursProjegt - ollHours;
                Console.WriteLine($"Not enough time!{Math .Ceiling (different1)} hours needed.");
            }
            //•	Ако времето НЕ Е достатъчно:
            // "Not enough time!{ недостигащите часове} hours needed.“

        }
    }
}
