using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
        public class Task
        {
            public string name;
            public bool done;
            public Task(string taskName)
            {
                name = taskName;
                done = false;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Task> tasks = new List<Task>();

                tasks.Add(new Task("1.Погулять с собаками"));
                tasks.Add(new Task("2.Приготовить еду"));
                tasks.Add(new Task("3.Постирать вещи"));
                tasks.Add(new Task("4.Покормить собак"));
                tasks.Add(new Task("5.Заняться учебой"));

                while (true)
                {
                    Console.WriteLine("Введите 1. Добавить");
                    Console.WriteLine("Введите 2. Показать все");
                    Console.WriteLine("Введите 3. Пометить готово");
                    Console.WriteLine("Введите 4. Удалить задачу");
                    Console.WriteLine("Введите 5. Выход");


                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.WriteLine("Задача 1");
                        string new_task = Console.ReadLine(); 
                        tasks.Add(new Task(new_task));
                    }

                    if (choice == "2")
                    {
                        foreach (Task t in tasks)
                        {
                            Console.WriteLine($"Показываю все задачи: {t.done}, {t.name}");
                        }
                    }
                    if (choice == "3")
                {
                    Console.WriteLine("Номер задачи?");
                    foreach (Task t in tasks)
                    {
                        Console.WriteLine($"{t.done}, {t.name}");
                    }
                    int index = int.Parse(Console.ReadLine()) - 1;
                    if (index >= 00 & index < tasks.Count)
                    {
                        tasks[index].done = true;
                        Console.WriteLine("Успешно");
                    }
                    else 
                    {
                        Console.WriteLine("Номер введен неверно");
                    }
                }

                if (choice == "4")
                {
                    foreach (Task t in tasks)
                    {
                        Console.WriteLine($"Показываю все задачи: {t.done}, {t.name}");
                    }
                    Console.WriteLine("Задача 4");
                    int remove_task = int.Parse(Console.ReadLine()) - 1;
                    tasks.RemoveAt(remove_task);
                }
                    if (choice == "5")
                    {
                        break;
                    }                
            }
        }
    }
}