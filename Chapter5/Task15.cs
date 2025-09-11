using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task15
    {
        public static void Run()
        {
            Clear();
            decimal speed()
            {
                WriteLine("Введите расстояние на которое полетим");
                var i = decimal.Parse(ReadLine());
                decimal k = i / 8;
                return k;
            }
            WriteLine("Скорость вашей ракеты: " + speed());

        }


    }
}