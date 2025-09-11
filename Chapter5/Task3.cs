using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task3
    {
        public static void Run()
        {
            Clear();
            int age()
            {
                WriteLine("Сколько вам лет?");
                var i = ReadLine();
                var k = int.Parse(i);
                return k;
            }
            WriteLine(age());

        }


    }
}