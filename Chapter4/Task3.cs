using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter4
{
    public class Task3
    {
        public static void Run()
        {
            Clear();
            for (var i = 10; i <= 50; i++)
            {
                if (i > 20 && i < 40)
                {
                    continue;
                }
                WriteLine(i);
            }


        }


    }
}