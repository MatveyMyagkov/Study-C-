using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> chapters = new Dictionary<int, string>
        {
            {2, "Chapter2"},
            {3, "Chapter3"},
            {4, "Chapter4"},
            {5, "Chapter5"},
            {6, "Chapter6"},
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== ВЫБЕРИТЕ ГЛАВУ ===");

            foreach (var chapter in chapters)
            {
                Console.WriteLine($"{chapter.Key} - {chapter.Value}");
            }
            Console.WriteLine("0 - Выход");
            Console.Write("Ваш выбор: ");

            if (int.TryParse(Console.ReadLine(), out int chapterChoice))
            {
                if (chapterChoice == 0) return;
                if (chapters.ContainsKey(chapterChoice))
                {
                    ShowTasksMenu(chapters[chapterChoice]);
                }
            }
        }
    }

    static void ShowTasksMenu(string chapterName)
    {
        Dictionary<int, Action> tasks = new Dictionary<int, Action>();

        if (chapterName == "Chapter2")
        {
            tasks = new Dictionary<int, Action>
            {
                {1, Chapter2.Task1.Run},
                {2, Chapter2.Task2.Run},
                {3, Chapter2.Task3.Run},
                {4, Chapter2.Task4.Run},
                {5, Chapter2.Task5.Run},
                {6, Chapter2.Task6.Run},
                {7, Chapter2.Task7.Run},
                {8, Chapter2.Task8.Run},
                {9, Chapter2.Task9.Run},
                {10, Chapter2.Task10.Run},
                {11, Chapter2.Task11.Run},
                {12, Chapter2.Task12.Run},
                {13, Chapter2.Task13.Run},
                {14, Chapter2.Task14.Run},
            };
        }
        else if (chapterName == "Chapter3")
        {
            tasks = new Dictionary<int, Action>
            {
                {1, Chapter3.Task1.Run},
                {2, Chapter3.Task2.Run},
                {3, Chapter3.Task3.Run},
                {4, Chapter3.Task4.Run},
                {5, Chapter3.Task5.Run},
                {6, Chapter3.Task6.Run},

            };
        }
        else if (chapterName == "Chapter4")
        {
            tasks = new Dictionary<int, Action>
            {
                {1, Chapter4.Task1.Run},
                {2, Chapter4.Task2.Run},
                {3, Chapter4.Task3.Run},
                {4, Chapter4.Task4.Run},
                {5, Chapter4.Task5.Run},

            };
        }
        else if (chapterName == "Chapter5")
        {
            tasks = new Dictionary<int, Action>
            {
                {1, Chapter5.Task1.Run},
                {2, Chapter5.Task2.Run},
                {3, Chapter5.Task3.Run},
                {4, Chapter5.Task4.Run},
                {5, Chapter5.Task5.Run},
                {6, Chapter5.Task6.Run},
                {7, Chapter5.Task7.Run},
                {8, Chapter5.Task8.Run},
                {9, Chapter5.Task9.Run},
                {10, Chapter5.Task10.Run},
                {11, Chapter5.Task11.Run},
                {12, Chapter5.Task12.Run},
                {13, Chapter5.Task13.Run},
                {14, Chapter5.Task14.Run},
                {15, Chapter5.Task15.Run},
                {16, Chapter5.Task16.Run},
                {17, Chapter5.Task17.Run},

            };
        }
        else if (chapterName == "Chapter6")
        {
            tasks = new Dictionary<int, Action>
            {
                {1, Chapter6.Task1.Run},
                {2, Chapter6.Task2.Run},
                {3, Chapter6.Task3.Run},
                {4, Chapter6.Task4.Run},
                {5, Chapter6.Task5.Run},
                {6, Chapter6.Task6.Run},

            };
        }


        while (true)
        {
            Console.Clear();
            Console.WriteLine($"=== {chapterName.ToUpper()} ===");

            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Key} - Task{task.Key}");
            }
            Console.WriteLine("0 - Назад");
            Console.Write("Выберите задачу: ");

            if (int.TryParse(Console.ReadLine(), out int taskChoice))
            {
                if (taskChoice == 0) return;
                if (tasks.ContainsKey(taskChoice))
                {
                    tasks[taskChoice]();
                    Console.WriteLine("\nНажмите любую клавишу...");
                    Console.ReadKey();
                }
            }
        }
    }
}