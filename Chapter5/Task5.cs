using System;
using System.Collections.Generic;
using static System.Console;
namespace Chapter5
{
    public class Task5
    {
        public static void Run()
        {
            Clear();
            bool married()
            {
                WriteLine("Женаты ли вы? (Yes or No)");
                string a = ReadLine();
                if (a == "Yes")
                {
                    bool i = true;
                    return i;
                }
                else
                {
                    bool i = false;
                    return i;
                }

                
            }
            WriteLine(married());

        }


    }
}