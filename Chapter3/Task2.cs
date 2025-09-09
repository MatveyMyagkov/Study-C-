using static System.Console;
namespace Chapter3
{
    public class Task2
    {
        public static void Run()
        {
            Clear();
            WriteLine("Какой у вас пол (м или ж)");
            var a = ReadLine();
            if (a == "м") {
                WriteLine("Женаты ли вы?");
            }
            else
            {
                WriteLine("Замужем ли вы?");
            }
        }
    }
}
