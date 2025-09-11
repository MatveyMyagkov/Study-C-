using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter4
{
    public class Task1
    {
        public static void Run()
        {
            Clear();
            int s = 0;
            for (var i = 0; i <= 100; i++) 
            {
                s += i;
            }
            WriteLine(s);
            
        }

        
    }
}