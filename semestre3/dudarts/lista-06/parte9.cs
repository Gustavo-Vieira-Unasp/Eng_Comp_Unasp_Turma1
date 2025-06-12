namespace Exercicios;
using System;
using System.Collections.Generic;
using System.IO;
//Criar um programa que implemente um try-finally para garantir o fechamento de um arquivo

public class TryFinallyArquivo
{
    public void AbrirArquivo(string caminhoArquivo)
    {
        FileStream arquivo = null;
        try
        {
            arquivo = new FileStream(caminhoArquivo, FileMode.Open);
            Console.WriteLine("Arquivo aberto com sucesso!");
            // Aqui você pode manipular o arquivo se quiser
        }
        finally
        {
            // O finally sempre será executado, mesmo se der erro no try
            if (arquivo != null)
            {
                arquivo.Close();
                Console.WriteLine("Arquivo fechado.");
            }
        }
    }
}