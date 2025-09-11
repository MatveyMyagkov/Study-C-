using System;
using System.Collections.Generic;
using static System.Console;
class student_2
{
    public string name;
    public int classnumber;
    public string subject;

    public string liked()
    {
        WriteLine("Тебе нравится предмет, который ты выбрал?(да или нет)");
        var a = ReadLine();
        if (a == "да")
        {
            return "Урок начнется через час";
        }
        else {
            WriteLine("Какой предмет тебе нравится");
            var b = ReadLine();
            subject = b;
            return "";
        }
    }
}
namespace Chapter6
{
    public class Task6
    {
        public static void Run()
        {
            Clear();
            var Student_1 = new student_2();
            Student_1.name = "Ivan";
            Student_1.classnumber = 11;
            Student_1.subject = "Math";

            var Student_2 = new student_2();
            Student_2.name = "Vova";
            Student_2.classnumber = 9;
            Student_2.subject = "History";

            WriteLine(Student_2.liked());
            WriteLine("Любимый предмет " + Student_2.name + ": " + Student_2.subject);

        }


    }
}