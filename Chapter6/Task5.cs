using System;
using System.Collections.Generic;
using static System.Console;
class outerwear_2
{
    public string color;
    public string size;
    public string price;
    public string category()
    {
        WriteLine("Какая категория одежды вам нужна?");
        var a = ReadLine();
        return "Цвет: " + color +"\n" + 
            "Размер: " + size + "\n" + 
            "Цена: " + price + "\n" + 
            "Категория: " + a;
    }

}
namespace Chapter6
{
    public class Task5
    {
        public static void Run()
        {
            Clear();
            var Куртка = new outerwear_2();
            Куртка.color = "blue";
            Куртка.size = "M";
            Куртка.price = "$2";

            var Пальто = new outerwear_2();
            Пальто.color = "green";
            Пальто.size = "L";
            Пальто.price = "$5";

            var Шуба = new outerwear_2();
            Шуба.color = "white";
            Шуба.size = "S";
            Шуба.price = "$10";

            WriteLine(Пальто.category());

        }


    }
}