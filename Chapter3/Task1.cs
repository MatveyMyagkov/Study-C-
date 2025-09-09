using static System.Console;
namespace Chapter3
{
    public class Task1
    {
        public static void Run()
        {
            Clear();
            WriteLine("Как вас зовут?");
            var name = ReadLine();
            if (name == "admin")
            {
                WriteLine("Вы - администратор?");              
            }
        }
    }
}