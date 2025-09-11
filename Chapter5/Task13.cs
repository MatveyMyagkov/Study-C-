using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task13
    {
        public static void Run()
        {
            Clear();
            int buy()
            {
                WriteLine("Напишите на 3-х строчках стоимости покупок");
                int s = 0;
                for (var i = 0; i < 3; i++)
                {
                    s += int.Parse(ReadLine());
                }
                return s;
            }
            WriteLine("Общая стоимость продуктов:" + buy());

        }


    }
}