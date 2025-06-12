namespace Exercicios;
using System;
using System.Collections.Generic;
using System.IO;
// Criar um programa que implemente try-catch para capturar divisão por zero
public class DivisaoInvalida
{
    public DivisaoInvalida(int value_one, int value_two)
    {
        //try catch simples que pega os parametros e verifica se a divisão fornecida é válida
        try
        {
            Console.WriteLine($"Resultado da divisão: {value_one / value_two}");

        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Divisão por zero não é permitida.");
        }

        
    }
}