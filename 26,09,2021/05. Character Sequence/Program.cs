﻿using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                char leter = name[i];

                Console.WriteLine(leter);
            }
        }

    }
}