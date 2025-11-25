using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Универсальный калькулятор ---");

        double num1 = GetNumber("Введите первое число:");
        double num2 = GetNumber("Введите второе число:");

        Console.WriteLine("--- Результаты вычислений ---");

        var operations = new Dictionary<string, Func<double, double, double>>
        {
            ["Сложение"] = (a, b) => a + b,
            ["Вычитание"] = (a, b) => a - b,
            ["Умножение"] = (a, b) => a * b,
            ["Деление"] = (a, b) => b != 0 ? a / b : throw new DivideByZeroException(),
            ["Степень"] = (a, b) => Math.Pow(a, b),
            ["Остаток"] = (a, b) => b != 0 ? a % b : throw new DivideByZeroException()
        };

        foreach (var operation in operations)
        {
            UniversalCalculator(operation.Key, num1, num2, operation.Value);
        }
    }

    static void UniversalCalculator(string operationName, double x, double y, Func<double, double, double> operation)
    {
        try
        {
            double result = operation(x, y);
            Console.WriteLine($"{operationName}: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine($"{operationName}: Ошибка - деление на ноль!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{operationName}: Ошибка - {ex.Message}");
        }
    }

    static double GetNumber(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            if (double.TryParse(Console.ReadLine(), out double number))
                return number;
            Console.WriteLine("Ошибка: введите корректное число!");
        }
    }
}