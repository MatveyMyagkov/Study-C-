using static System.Console;
namespace Chapter3
{
    public class Task5
    {
        public static void Run()
        {
            Clear();
            WriteLine("Сколько вам лет?");
            var a = Int32.Parse(ReadLine());
            if (a < 18)
            {
                WriteLine("доступ запрещен");
            }
            else {
                WriteLine("Доступ разрешен");
            }
        }
    }
}
