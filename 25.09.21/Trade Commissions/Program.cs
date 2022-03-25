using System;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            //град    0 ≤ s ≤ 500    500 < s ≤ 1 000     1 000 < s ≤ 10 000        s > 10 000
            //Sofia      5 %             7 %               8 %                      12 %
            //Varna      4.5 %            7.5 %            10 %                      13 %
            //Plovdiv    5.5 %             8 %            12 %                      14.5 %

            //Напишете конзолна програма, която чете име на град(стринг) и обем на продажби(реално число) , въведени от потребителя, и изчислява и
            //    извежда размера на търговската комисионна според горната таблица.Резултатът да се изведе 
            //    форматиран до 2 цифри след десетичната точка. При невалиден град или обем на продажбите(отрицателно число) да се отпечата "error".
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;
            if (city == "Sofia")
            {

                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.05;
                }

                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.12;
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.045;
                }

                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.10;
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.13;
                }
            }

            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.055;
                }

                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.145;
                }


            }


            if (commission  == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{(commission):f2}");
            }



        }
    }
}
