using System;

namespace Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която проверява дали първоначално налична сума е достатъчна, за да се заплати карта за месечен достъп във фитнес.
            //Цената на картата зависи от пола на клиента и спорта, който практикува:
            //            Пол    Gym   Boxing    Yoga    Zumba    Dances    Pilates
            //            мъж	 $42    $41      $45     $34       $51         $39
            //            жена   $35    $37      $42     $31       $53         $37

          
            //На конзолата се отпечатва 1 ред:
            //•	Ако сумата е достатъчна:
            //"You purchased a 1 month pass for {sport}."
            //където { sport} е въведения тип спорт
            //•	Ако сумата не е достатъчна трябва да се пресметне колко още пари са необходими, за да се закупи карта:
            //"You don't have enough money! You need ${money} more."
            //където { money}
            //e оставащата сума нужна, за да се закупи картата, форматирана до втория знак след десетичната запетая.
            double sum = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double total = 0;
            if (sex == "m")
            {
                switch (sport)
                {
                    case "Gym":
                        total = 42;
                        break;
                    case "Boxing":
                        total = 41;

                        break;
                    case "Yoga":
                        total = 45;

                        break;
                    case "Zumba":
                        total = 34;

                        break;
                    case "Dances":
                        total = 51;

                        break;
                    case "Pilates":
                        total = 39;

                        break;
                }
            }
                if (sex == "f")
                {
                    switch (sport)
                    {
                        case "Gym":
                            total = 35;
                            break;
                        case "Boxing":
                            total = 37;

                            break;
                        case "Yoga":
                            total = 42;

                            break;
                        case "Zumba":
                            total = 31;

                            break;
                        case "Dances":
                            total = 53;

                            break;
                        case "Pilates":
                            total = 37;

                            break;
                    }
                }
            if (age <= 19)
            {
                total *= 0.80;
            }
            if (total<= sum)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
            double differents = total - sum;
                Console.WriteLine($"You don't have enough money! You need ${differents:f2} more.");

            }
        }
    }
}
