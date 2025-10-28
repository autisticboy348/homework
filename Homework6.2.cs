using System;

public class ArrayReverser
{
    public static void Main(string[] args)
    {
        int[] originalArray = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Исходный массив:");
        PrintArray(originalArray);
        Console.WriteLine();

        int[] reversedArray = new int[originalArray.Length];

        for (int i = 0; i < originalArray.Length; i++)
        {
            reversedArray[i] = originalArray[originalArray.Length - 1 - i];
        }

        Console.WriteLine("Перевернутый массив:");
        PrintArray(reversedArray);
    }

    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1)
            {
                Console.Write(" ");
            }
        }
    }
}
