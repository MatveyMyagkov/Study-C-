using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static System.Console;
class turist_2
{
    public string Name;
    public int Age;
    public string Travel;
    public string info()
    {
        return Name + " Отправляется в " + Travel;
    }

}
namespace Chapter6
{
    public class Task4
    {
        public static void Run()
        {
            Clear();
            var turist = new turist_2();
            turist.Name = "Matvey";
            turist.Age = 18;
            turist.Travel = "Moscow";

            WriteLine(turist.info());
        }


    }
}