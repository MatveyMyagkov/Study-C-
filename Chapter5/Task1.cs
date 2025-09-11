using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task1
    {
        public static void Run()
        {
            Clear();
            string surname()
            {
                WriteLine("Введите вашу фамилию");
                var a = ReadLine();
                return a;
            }
            WriteLine(surname());

        }


    }
}