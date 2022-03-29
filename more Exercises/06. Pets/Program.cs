using System;

namespace _06._Pets
{
    class Program
    {
        static void Main(string[] args)
        {

            int day = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double foodDayDog = double.Parse(Console.ReadLine());
            double foodDayCat = double.Parse(Console.ReadLine());
            double foodDayTurtle = double.Parse(Console.ReadLine());
            double totalFoodDog = day * foodDayDog;
            double totalFoodCat = day * foodDayCat;
            double totalFoodTurtle = day * (foodDayTurtle / 1000);
            double total = totalFoodDog + totalFoodCat + totalFoodTurtle;

            //            •	Ако оставената храна Е достатъчна:
            //            o   "{килограма остатък} kilos of food left."
            //	Резултатът трябва да е закръглен към по - ниското цяло число
            if (total <=food )
            {
                double different = food -total ;
                Console.WriteLine($"{Math.Floor (different)} kilos of food left.");
            }
            else
            {
                double different1 = total -food ;
                Console.WriteLine($"{Math .Ceiling (different1 )} more kilos of food are needed.");
            }
            //•	Ако оставената храна НЕ Е достатъчна:
            //o   “{ килограма недостигат} more kilos of food are needed.”
            //	Резултатът трябва да е закръглен към по - високото цяло число


        }
    }
}
