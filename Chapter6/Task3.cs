using System;
using System.Collections.Generic;
using static System.Console;
class student
{
    public string name;
    public int classnumber;
    public string subject;
}
namespace Chapter6
{
    public class Task3
    {
        public static void Run()
        {
            Clear();
            var Student_1 = new student();
            Student_1.name = "Ivan";
            Student_1.classnumber = 11;
            Student_1.subject = "Math";

            var Student_2 = new student();
            Student_2.name = "Vova";
            Student_2.classnumber = 9;
            Student_2.subject = "History";



        }


    }
}