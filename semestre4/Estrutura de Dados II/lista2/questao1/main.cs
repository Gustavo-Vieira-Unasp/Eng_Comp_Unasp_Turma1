using System;

public class Program
{
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void Main(string[] args)
    {
        int x = 5;
        int y = 10;

        Console.WriteLine($"Valores antes da troca: x = {x}, y = {y}");

        Swap(ref x, ref y);

        Console.WriteLine($"Valores depois da troca: x = {x}, y = {y}");
    }
}