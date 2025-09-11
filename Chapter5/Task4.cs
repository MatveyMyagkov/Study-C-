using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task4
    {
        public static void Run()
        {
            Clear();
            string gender()
            {
                WriteLine("Какой у вас пол? (Мужской или Женский)");
                var i = ReadLine();
                return i;

            }
            WriteLine(gender());

        }


    }
}