using System;
using System.Collections.Generic;
using static System.Console;
class outerwear
{
    public string color;
    public string size;
    public string price;
}
namespace Chapter6
{
    public class Task2
    {
        public static void Run()
        {
            Clear();
            var Куртка = new outerwear();
            Куртка.color = "blue";
            Куртка.size = "M";
            Куртка.price = "$2";

            var Пальто = new outerwear();
            Пальто.color = "green";
            Пальто.size = "L";
            Пальто.price = "$5";

            var Шуба = new outerwear();
            Шуба.color = "white";
            Шуба.size = "S";
            Шуба.price = "$10";



        }


    }
}