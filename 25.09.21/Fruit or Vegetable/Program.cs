﻿using System;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Плодовете "fruit" имат следните възможни стойности:  banana, apple, kiwi, cherry, lemon и grapes
            //•	Зеленчуците "vegetable" имат следните възможни стойности:  tomato, cucumber, pepper и carrot
            //•	Всички останали са "unknown"
            string name = Console.ReadLine();
            switch (name)
            {
                case "banana":
                    case  "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                               Console.WriteLine("vegetable");
                    break;
                default:
                                   
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
