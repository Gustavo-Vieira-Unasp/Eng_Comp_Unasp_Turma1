namespace Exercicios;
using System;
using System.Collections.Generic;
using System.IO;
//Criar um programa que tente abrir um arquivo inexistente e capture a exceção

public class ArquivoExistente
{
    public ArquivoExistente(string filepath)
    {
        try
        {
            FileInfo arquivo = new FileInfo(filepath); // Cria um objeto FileInfo para o caminho informado
            using (var abrir = arquivo.Open(FileMode.Open)) // Tenta abrir o arquivo
            {
                Console.WriteLine("Arquivo aberto com sucesso!");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Arquivo inexistente.");
        }
    }
}