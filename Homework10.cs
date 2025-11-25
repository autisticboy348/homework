using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string input = " иванов иван,петров петр, сидорова Анна, бобров БОРИС ";

        Console.WriteLine("--- Форматирование списка пользователей ---");
        Console.WriteLine($"Исходная строка: \"{input}\"");

        string formattedList = FormatUserList(input);

        Console.WriteLine("Отформатированный список:");
        Console.WriteLine(formattedList);
    }

    static string FormatUserList(string input)
    {
        string[] rawEntries = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        List<string> formattedUsers = new List<string>();

        for (int i = 0; i < rawEntries.Length; i++)
        {
            string formattedUser = FormatSingleUser(rawEntries[i].Trim());
            if (!string.IsNullOrEmpty(formattedUser))
            {
                formattedUsers.Add($"{i + 1}. {formattedUser}");
            }
        }

        return string.Join(" ", formattedUsers);
    }

    static string FormatSingleUser(string rawUser)
    {
        if (string.IsNullOrWhiteSpace(rawUser))
            return string.Empty;

        string[] parts = rawUser.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length < 2)
            return string.Empty;

        string lastName = FormatNamePart(parts[0]);
        string firstName = FormatNamePart(parts[1]);

        return $"{lastName} {firstName}";
    }

    static string FormatNamePart(string namePart)
    {
        if (string.IsNullOrWhiteSpace(namePart))
            return string.Empty;

        return char.ToUpper(namePart[0]) + namePart.Substring(1).ToLower();
    }
}
