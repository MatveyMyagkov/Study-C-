using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task17
    {
        public static void Run()
        {
            Clear();
            int v()
            {
                WriteLine("Введите на отдельных строчках: длину, высоту и ширину");

                var a = int.Parse(ReadLine());
                var b = int.Parse(ReadLine());
                var c = int.Parse(ReadLine());
                return a * b * c;
            }
            WriteLine(v());

        }


    }
}