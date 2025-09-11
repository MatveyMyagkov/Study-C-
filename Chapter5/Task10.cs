using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task10
    {
        public static void Run()
        {
            Clear();
            string worker()
            {
                WriteLine("Сколько у тебя сотрудников?");
                var i = int.Parse(ReadLine());
                if (i == 1)
                {
                    return "1 человек поздравляет тебя с Юбилеем";
                }
                else if (i >= 2 && i <= 4)
                {
                    return i + "человека поздравляют тебя с Юбилеем";
                }
                else
                {
                    return "Все сотрудники поздравляют тебя с Юбилеем"; 
                }
            }
            WriteLine(worker());

        }


    }
}