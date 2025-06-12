namespace Exercicios;
using System;
using System.Collections.Generic;
using System.IO;
//Criar um método que escreva um texto em um arquivo .txt

public class EscreverTXT
{

    public void WriteTXT(string filepath)
    {
        try
        {
            Console.WriteLine("Digitie o texto no arquivo txt: ");
            string texto = Console.ReadLine(); //le o arquivo para alterar depois
            File.WriteAllText(filepath, texto); // Escreve o texto no arquivo
            Console.WriteLine("Texto escrito com sucesso!");
        }
        catch (Exception ex)
        { 
            Console.WriteLine($"Erro ao escrever no arquivo: {ex.Message}");
        }
    }
}