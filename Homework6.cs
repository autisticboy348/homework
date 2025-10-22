using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("your number here: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("error");
            return;
        }

        int result = CalculateFactorial(n);
        Console.WriteLine($"factorial of number {n} is {result}");
    }

    static int CalculateFactorial(int n)
    {
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
