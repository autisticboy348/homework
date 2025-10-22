using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string playAgain;

        do
        {
            Console.Clear();
            Console.WriteLine("=== угадай число за 7 попыток ===");

            int secretNumber = random.Next(1, 101);
            int maxAttempts = 7;
            int attempts = 0;
            bool hasWon = false;

            while (attempts < maxAttempts && !hasWon)
            {
                attempts++;

                if (!int.TryParse(Console.ReadLine(), out int userGuess))
                {
                    Console.WriteLine("недопускаются дробные числа");
                    attempts--; 
                    continue;
                }

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("вы угадали число!");
                    hasWon = true;
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("попробуйте число побольше");
                }
                else
                {
                    Console.WriteLine("попробуйте число поменьше");
                }

                if (!hasWon && attempts < maxAttempts)
                {
                    Console.WriteLine($"попыток: {maxAttempts - attempts}");
                }
            }

            if (!hasWon)
            {
                Console.WriteLine($"вы проиграли");
            }

            Console.Write("ещё раз? (да/yes или любой другой ответ для выхода): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "да" || playAgain == "yes");

        Console.WriteLine("");
        Console.ReadLine();
    }
}