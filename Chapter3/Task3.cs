using static System.Console;
namespace Chapter3
{
    public class Task3
    {
        public static void Run()
        {
            Clear();
            WriteLine("Какой у вас пол (м или ж)");
            var a = ReadLine();
            if (a == "м")
            {
                WriteLine("Женаты ли вы? (да или нет)");
                var b = ReadLine();
                if (b == "да")
                {
                    WriteLine("вы женаты");
                }
            }
            else
            {
                WriteLine("Замужем ли вы?");
                var b = ReadLine();
                if (b == "да")
                {
                    WriteLine("вы замужем");
                }
            }
        }
    }
}
