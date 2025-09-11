using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task11
    {
        public static void Run()
        {
            Clear();
            string HB()
            {
                WriteLine("Введите дату своего рождения");
                var s = ReadLine();
                while (s == ""){
                    WriteLine("Введите дату своего рождения");
                    s = ReadLine();
                }
                return s; 
            }
            WriteLine(HB());

        }


    }
}