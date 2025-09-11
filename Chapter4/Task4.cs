using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter4
{
    public class Task4
    {
        public static void Run()
        {
            Clear();
            int s = 0;
            for (var i = 0; i <= 1000; i++)
            {
                if (s + i > 100000) {
                    WriteLine(i);
                    break;
                }
                s += i;
            }

        }


    }
}