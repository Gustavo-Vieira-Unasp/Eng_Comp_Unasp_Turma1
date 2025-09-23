using System;

public class MathOperations
{
    public static void CalculateSumAndProduct(int a, int b, out int sum, out int product)
    {
        sum = a + b;
        product = a * b;
    }

    public static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;

        int resultSum;
        int resultProduct;

        CalculateSumAndProduct(num1, num2, out resultSum, out resultProduct);

        Console.WriteLine($"Os números são: {num1} e {num2}");
        Console.WriteLine($"A soma é: {resultSum}");
        Console.WriteLine($"O produto é: {resultProduct}");
    }
}