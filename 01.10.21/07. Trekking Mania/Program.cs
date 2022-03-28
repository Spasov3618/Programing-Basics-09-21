using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Група до 5 човека – изкачват Мусала
            //•	Група от 6 до 12 човека – изкачват Монблан
            //•	Група от 13 до 25 човека – изкачват Килиманджаро
            //•	Група от 26 до 40 човека –  изкачват К2
            //•	Група от 41 или повече човека – изкачват Еверест
           //Да се напише програма, която изчислява процента на катерачите изкачващи всеки връх.
                      
            int group = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            double num = 0;
            for (int i = 0; i < group; i++)
            {
                int numOfGrup = int.Parse(Console.ReadLine());

                if (numOfGrup < 6)
                {
                    p1 += numOfGrup;
                }
                else if (numOfGrup < 13)
                {
                    p2 += numOfGrup;
                }
                else if (numOfGrup < 26)
                {
                    p3 += numOfGrup;
                }
                else if (numOfGrup < 41)
                {
                    p4 += numOfGrup;
                }
                else
                {
                    p5 += numOfGrup;
                }
            }
                num = p1 + p2 + p3 + p4 + p5;
            
                double percentP1 = 1.0 * p1 /num   * 100;
                double percentP2 = 1.0 * p2 / num   * 100;
                double percentP3 = 1.0 * p3 / num   * 100;
                double percentP4 = 1.0 * p4 / num   * 100;
                double percentP5 = 1.0 * p5 / num   * 100;
                Console.WriteLine($"{percentP1:f2}%");
                Console.WriteLine($"{percentP2:f2}%");
                Console.WriteLine($"{percentP3:f2}%");
                Console.WriteLine($"{percentP4:f2}%");
                Console.WriteLine($"{percentP5:f2}%");
            }
                
        
    }
}
