Console.WriteLine("--- Калькулятор Индекса Массы Тела (ИМТ) ---");
Console.WriteLine(" ");
Console.WriteLine("Введите ваш вес в килограммах:");
int weight = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваш рост в метрах (например, 1.75):");

Console.WriteLine(" ");
Console.WriteLine("--- Ваш результат ---");
double height = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"При весе {weight} кг и росте {height} м, ваш ИМТ составляет: {weight / (height * height)}");