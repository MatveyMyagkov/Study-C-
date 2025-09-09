using static System.Console;
namespace Chapter3
{
    public class Task6
    {
        public static void Run()
        {
            WriteLine("Где ты живешь?");
            var a = ReadLine();
            if (a == "РФ")
            {
                WriteLine("Вы живете в Российской Федерации");
            }
            else if (a == "Китай")
            {
                WriteLine("Вы живете в Китае");
            }
            else if (a == "Турция")
            {
                WriteLine("Вы живете в Турции");
            }
            else {
                WriteLine("Вы живете в стране: " + a);
            }
        }
    }
}