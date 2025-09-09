using static System.Console;
namespace Chapter2

{
    public class Task14
    {
        public static void Run()
        {
            Clear();
            int a = -1;
            a += 1;
            WriteLine(a);
            // a = 100 / a; Данная строчка выдает ошибку, так как деление на 0 не может быть посчитано программой
            // WriteLine(a);
        }
    }
}
