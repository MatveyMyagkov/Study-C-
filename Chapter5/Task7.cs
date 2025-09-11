using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task7
    {
        public static void Run()
        {
            Clear();
            string allergy()
            {
                WriteLine("У вас есть аллергия? (Yes or No)");
                string a = ReadLine();
                if (a == "Yes")
                {
                    WriteLine("На что у вас аллергия");
                    var b = ReadLine();
                    return "У вас аллергия на: " + b;
                }
                else
                {
                    return "У вас нет аллергии";
                }


            }
            WriteLine(allergy());


        }


    }
}