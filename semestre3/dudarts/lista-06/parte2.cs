namespace Exerticios;
using System;
using System.Collections.Generic;
using System.IO;
// Criar um programa que capture exceções ao acessar um índice inválido de um array


public class IndiceInvalido
{   
    public IndiceInvalido(int[] array, int indece)// int[] é usado para criar um array de inteiros
    {
        //try catch simples que pega os parametros e verifica se o indice fornecido é válido
        try
        {
            Console.WriteLine($"Valor no índice {indece}: {array[indece]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Índice fora dos limites do array.");
        }
    }
}