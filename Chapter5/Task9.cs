using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task9
    {
        public static void Run()
        {
            Clear();
            string girl()
            {
                WriteLine("Как тебя зовут?");
                var a = ReadLine();
                return "Дорогая, " + a + ", ты сегодня как всегда прекрасно выглядишь";
            }
            WriteLine(girl());

        }


    }
}