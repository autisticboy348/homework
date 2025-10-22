Console.WriteLine("Your number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your second number:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your sign:");
char sign = Convert.ToChar(Console.ReadLine());
if (sign == '+')
{
    Console.WriteLine(num1 + num2);
}
else if (sign == '-')
{
    Console.WriteLine(num1 - num2);
}
else if (sign == '/')
{
    Console.WriteLine(num1 / num2);
}
else if (sign == '*')
{
    if (num2 == 0)
    {
        Console.WriteLine("Error");
    }
    else
    {
        Console.WriteLine(num1 * num2);
    }
}
else
{
    Console.WriteLine("Error");
}

