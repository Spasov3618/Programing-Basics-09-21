using System;

namespace _1._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Напишете програма, която определя дали на базата на дадена възраст човек е: бебе, дете, тийнейджър, възрастен, по - възрастен.Границите са:
            //• 0 - 2 – бебе;
            //• 3 - 13 – дете;
            //• 14 - 19 – тийнейджър;
            //• 20 - 65 – възрастен;
            //• >= 66 – старейшина;
            //• Всички стойности са включени. 
           // baby, child, teenager, adult, elder
            int age = int.Parse(Console.ReadLine());
            string ageNow = "";
            if (age>=0 && age <=2)
            {
                ageNow = "baby";
            }
            else if (age>=3&&age<=13)
            {
                ageNow = "child";
            }
            else if (age>=14&&age<=19)
            {
                ageNow = "teenager";
            }
            else if (age>=20 && age<=65)
            {
                ageNow = "adult";
            }
            else
            {
                ageNow = "elder";
            }
            Console.WriteLine(ageNow);
        }
    }
}
