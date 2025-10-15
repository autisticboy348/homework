Console.WriteLine("write sides of triangle:");

int side1 = Convert.ToInt32(Console.ReadLine());
int side2 = Convert.ToInt32(Console.ReadLine());
int side3 = Convert.ToInt32(Console.ReadLine());

if (side1 == side2 && side2 == side3)
{
    Console.WriteLine("equilateral");
}
else if (side1 == side2 || side2 == side3)
{
    Console.WriteLine("isosceles");
}
else if (side1 != side2 && side1 != side3 || side2 != side3)
{
    Console.WriteLine("versatile");
}
else
{
    Console.WriteLine("error!");
}