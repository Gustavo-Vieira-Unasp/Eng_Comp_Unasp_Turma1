using System;
using System.Diagnostics.CodeAnalysis;

class Soma
{
    // Função que calcula a soma de 1 até num
    static int Somatorio(int num)
    {
        int soma = 0;
        // Calcula a soma dos números de 1 até num
        for (int i = 1; i <= num; i++)
        {
            soma += i;
        }
        return soma;
    }

    static void Main()
    {
        // Solicita a entrada do número
        Console.WriteLine($"Digite um número:");
        int numero = Int32.Parse(Console.ReadLine()?? "0");
        int soma = Somatorio(numero);
        // Chama a função Somatorio e exibe o resultado
        Console.WriteLine($"{numero} -> {soma}");
    }
}


