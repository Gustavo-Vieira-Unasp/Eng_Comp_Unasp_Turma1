namespace Exercicios;
using System;
using System.Collections.Generic;
using System.IO;
//Criar um método que leia um arquivo .txt e exiba seu conteúdo

public class ExibirTXT
{
    public LerTXT(string filepath)
    {
        // try catch por precaução, caso o arquivo não exista ou ocorra algum erro ao ler
        try
        {
            if (file.Exists(filepath))
            {
                string corpo = file.ReadAllText(filepath); // Lê todo o conteúdo do arquivo
                Console.WriteLine($"Conteúdo do arquivo: {corpo}");

            }

            else
            {
                Console.WriteLine("Arquivo não encontrado.");
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
        }
    
    }
        
}