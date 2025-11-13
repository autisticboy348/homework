using System;

namespace UniversitySystem
{
    public struct Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"\"{Title}\" автора {Author}";
        }
    }

    public class Student
    {
        private static int _studentCount = 0;

        public static int StudentCount => _studentCount;

        public string Name { get; set; }
        public Book FavoriteBook { get; set; }

        public Student(string name, Book favoriteBook)
        {
            Name = name;
            FavoriteBook = favoriteBook;
            _studentCount++;
        }

        public override string ToString()
        {
            return $"{Name}, его любимая книга: {FavoriteBook}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Система учета студентов ---");

            Console.WriteLine($"Начальное количество студентов в системе: {Student.StudentCount}");

            Book book1 = new Book("Хоббит", "Дж. Р. Р. Толкин");
            Student student1 = new Student("Иван", book1);
            Console.WriteLine($"Создан студент {student1.Name}.");
            Console.WriteLine($"Текущее количество студентов в системе: {Student.StudentCount}");

            Book book2 = new Book("Преступление и наказание", "Ф. М. Достоевский");
            Student student2 = new Student("Анна", book2);
            Console.WriteLine($"Создан студент {student2.Name}.");
            Console.WriteLine($"Текущее количество студентов в системе: {Student.StudentCount}");

            Book book3 = new Book("Мастер и Маргарита", "М. А. Булгаков");
            Student student3 = new Student("Сергей", book3);
            Console.WriteLine($"Создан студент {student3.Name}.");
            Console.WriteLine($"Текущее количество студентов в системе: {Student.StudentCount}");

            Console.WriteLine("\n--- Эксперимент с копированием ---");

            Console.WriteLine($"Оригинальный студент: {student1}");
            Console.WriteLine("...Копируем данные и вносим изменения...");

            Student studentCopy = student1;

            Book bookCopy = student1.FavoriteBook;

            Console.WriteLine("Изменяем имя у копии студента на 'Петр'.");
            studentCopy.Name = "Петр";

            Console.WriteLine("Изменяем название у копии книги на 'Властелин Колец'.");
            bookCopy.Title = "Властелин Колец";

            Console.WriteLine("\nРезультат после изменений:");
            Console.WriteLine($"Имя оригинального студента (student1): {student1.Name}");
            Console.WriteLine($"Название любимой книги оригинального студента (student1.FavoriteBook): {student1.FavoriteBook.Title}");

            Console.WriteLine("\nВывод: Имя студента изменилось, так как классы копируются по ссылке.");
            Console.WriteLine("Вывод: Книга не изменилась, так как структуры копируются по значению.");

            Console.WriteLine("\n--- Дополнительная демонстрация ---");
            Console.WriteLine($"Оригинальный student1: {student1}");
            Console.WriteLine($"Копия studentCopy: {studentCopy}");
            Console.WriteLine($"Оригинальная книга: \"{student1.FavoriteBook.Title}\"");
            Console.WriteLine($"Копия книги: \"{bookCopy.Title}\"");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }

}
