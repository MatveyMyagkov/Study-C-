using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task16
    {
        public static void Run()
        {
            Clear();
            string hours()
            {
                WriteLine("Какой сейчас час?");
                var i = int.Parse(ReadLine());
                if (i >= 0 && i <= 6)
                {
                    return "Доброй ночи";
                }
                else if (i > 6 && i <= 12)
                {
                    return "Доброе утро";
                }
                else if (i > 12 && i <= 18)
                {
                    return "Добрый день";
                }
                else
                {
                    return "Добрый вечер";
                }
            }
            WriteLine(hours());

        }


    }
}