using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task6
    {
        public static void Run()
        {
            Clear();
            bool liked()
            {
                WriteLine("Любите ли вы кофе? (Да or Нет)");
                string a = ReadLine();
                if (a == "Да")
                {
                    bool i = true;
                    return i;
                }
                else
                {
                    bool i = false;
                    return i;
                }


            }
            WriteLine(liked());



        }


    }
}
