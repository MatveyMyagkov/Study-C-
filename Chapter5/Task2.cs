using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task2
    {
        public static void Run()
        {
            Clear();
            string name()
            {
                WriteLine("Как вас зовут?");
                var name = ReadLine();
                return name;
            }
            string surname()
            {
                WriteLine("Введите вашу фамилию");
                var a = ReadLine();
                return a;
            }
            WriteLine(surname() + " " + name());

        }


    }
}