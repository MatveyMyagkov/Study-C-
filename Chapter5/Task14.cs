using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task14
    {
        public static void Run()
        {
            Clear();
            string daughter()
            {
                WriteLine("Как зовут трех ваших дочек?");
                var s = "";
                for (var i = 0; i < 3; i++)
                {
                    s += ReadLine() + " ";
                }
                return "Ваших дочерей зовут: " + s;
            }
            WriteLine(daughter());


        }


    }
}