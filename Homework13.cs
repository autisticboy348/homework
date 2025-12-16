using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double AverageScore { get; set; }

    public string FullName => $"{LastName} {FirstName}";

    public Student(string firstName, string lastName, int age, double averageScore)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        AverageScore = averageScore;
    }
}

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Иван", "Петров", 20, 85.5),
            new Student("Анна", "Сидорова", 23, 78.1),
            new Student("Олег", "Кузнецов", 19, 74.9),
            new Student("Мария", "Васильева", 26, 88.3),
            new Student("Алексей", "Смирнов", 22, 95.2)
        };

        Console.WriteLine("--- Список студентов-хорошистов (балл от 75 до 90) ---");
        var goodStudents = students
            .Where(s => s.AverageScore >= 75 && s.AverageScore <= 90)
            .OrderByDescending(s => s.AverageScore);

        foreach (var student in goodStudents)
        {
            Console.WriteLine($"{student.FullName} - {student.AverageScore:F1}");
        }

        Console.WriteLine("\n--- Все студенты ---");
        var studentNames = students
            .Select(s => s.FullName);

        foreach (var name in studentNames)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("\n--- Сортировка по возрасту ---");
        var studentsByAge = students
            .OrderBy(s => s.Age);

        foreach (var student in studentsByAge)
        {
            string yearWord = GetYearWord(student.Age);
            Console.WriteLine($"{student.FullName} - {student.Age} {yearWord}");
        }

        Console.WriteLine("\n--- Рейтинг студентов младше 25 лет (по убыванию балла) ---");
        var youngStudentsRating = students
            .Where(s => s.Age < 25)
            .OrderByDescending(s => s.AverageScore)
            .Select(s => $"{s.FullName} - {s.AverageScore:F1}");

        foreach (var studentInfo in youngStudentsRating)
        {
            Console.WriteLine(studentInfo);
        }
    }

    private static string GetYearWord(int age)
    {
        int lastDigit = age % 10;
        int lastTwoDigits = age % 100;

        if (lastTwoDigits >= 11 && lastTwoDigits <= 19)
            return "лет";

        return lastDigit switch
        {
            1 => "год",
            2 or 3 or 4 => "года",
            _ => "лет"
        };
    }

}
