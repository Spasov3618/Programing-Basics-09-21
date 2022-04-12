using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[3]; 

            for (int i = 0; i < intArray.Length; i++) 
            {

                intArray[i] = int.Parse(Console.ReadLine()); 

            }
            Array.Sort(intArray);
            Array.Reverse(intArray);

            for (int x = 0; x < intArray.Length; x++)
            {
                Console.WriteLine(intArray[x]); 
            }
        }
    }
}
