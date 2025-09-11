using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task12
    {
        public static void Run()
        {
            Clear();
            string films()
            {
                WriteLine("Сколько у вас любимых фильмов?");
                var i = int.Parse(ReadLine());
                var s = "";
                for (var k = 0; k < i; k++)
                {
                    WriteLine("Введите " + (k + 1) + " фильм");
                    s += ReadLine() + "\n";
                }
                return s;
            }
            WriteLine(films());

        }


    }
}