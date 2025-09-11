using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task8
    {
        public static void Run()
        {
            Clear();
            int count()
            {
                WriteLine("Сколько раз вы женаты?");
                var i = int.Parse(ReadLine());
                while (i < 0 || i > 100)
                {
                    WriteLine("Введите количество в пределах от 0 до 100");
                    i = int.Parse(ReadLine());
                }
                return i;
            }
            WriteLine(count());

        }


    }
}