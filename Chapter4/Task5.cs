using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter4
{
    public class Task5
    {
        public static void Run()
        {
            Clear();
            for (var i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    WriteLine(i);
                }
            }


        }


    }
}