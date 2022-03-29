using System;

namespace _08._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string gasolin = Console.ReadLine().ToLower();
            int liter = int.Parse(Console.ReadLine());

            if (gasolin == "diesel" || gasolin == "gasoline" || gasolin == "gas")
            {
                if (liter >= 25)
                {
                    Console.WriteLine($"You have enough {gasolin}.");
                }
                else if (liter < 25)
                {
                    Console.WriteLine($"Fill your tank with {gasolin}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }  
            
        }
    }
}
