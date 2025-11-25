using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class TaskItem
    {
        public string Description { get; set; }
        public bool IsDone { get; set; }

        public TaskItem(string description)
        {
            Description = description;
            IsDone = false;
        }

        public string GetDisplayString(int index)
        {
            string status = IsDone ? "[X]" : "[ ]";
            return $"{index}. {status} {Description}";
        }
    }

    static void Main(string[] args)
    {
        List<TaskItem> tasks = new List<TaskItem>();

        while (true)
        {
            Console.WriteLine("=== МЕНЮ УПРАВЛЕНИЯ ЗАДАЧАМИ ===");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Посмотреть задачи");
            Console.WriteLine("3. Отметить задачу как выполненную");
            Console.WriteLine("4. Выйти");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask(tasks);
                    break;

                case "2":
                    DisplayTasks(tasks);
                    break;

                case "3":
                    MarkTaskAsDone(tasks);
                    break;

                case "4":
                    Console.WriteLine("Программа завершена. До свидания!");
                    return;

                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void AddTask(List<TaskItem> tasks)
    {
        Console.Write("\nВведите описание новой задачи: ");
        string description = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(description))
        {
            TaskItem newTask = new TaskItem(description);
            tasks.Add(newTask);
            Console.WriteLine($"Задача \"{description}\" успешно добавлена!");
        }
        else
        {
            Console.WriteLine("Описание задачи не может быть пустым!");
        }
    }

    static void DisplayTasks(List<TaskItem> tasks)
    {
        Console.WriteLine("\n--- Текущие задачи ---");

        if (tasks.Count == 0)
        {
            Console.WriteLine("Список задач пуст.");
            return;
        }

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine(tasks[i].GetDisplayString(i + 1));
        }

        int completedCount = tasks.Count(task => task.IsDone);
        Console.WriteLine($"Всего задач: {tasks.Count}, выполнено: {completedCount}");
    }

    static void MarkTaskAsDone(List<TaskItem> tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("\nСписок задач пуст. Нечего отмечать.");
            return;
        }

        Console.WriteLine("--- Отметить задачу как выполненную ---");
        DisplayTasks(tasks);

        Console.Write("Введите номер задачи для выполнения: ");

        if (int.TryParse(Console.ReadLine(), out int taskNumber))
        {
            if (taskNumber >= 1 && taskNumber <= tasks.Count)
            {
                TaskItem task = tasks[taskNumber - 1];

                if (!task.IsDone)
                {
                    task.IsDone = true;
                    Console.WriteLine($"Задача \"{task.Description}\" отмечена как выполненная!");
                }
                else
                {
                    Console.WriteLine($"Задача \"{task.Description}\" уже выполнена!");
                }
            }
            else
            {
                Console.WriteLine($"Неверный номер задачи. Должен быть от 1 до {tasks.Count}.");
            }
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректный номер.");
        }
    }
}
