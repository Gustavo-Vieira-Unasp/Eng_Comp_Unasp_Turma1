namespace Exercicios;
using System;
using System.Collections.Generic;
using System.IO;
//Criar um programa que registre logs de erros em um arquivo .log.

public class Logger
{
    private string logPath;

    // Construtor: define o caminho do arquivo de log
    public Logger(string logPath)
    {
        this.logPath = logPath;
    }

    // Método para registrar uma mensagem de erro no arquivo de log
    public void RegistrarErro(string mensagem)
    {
        try
        {
            // Apenas adiciona a mensagem ao final do arquivo log (cria se não existir)
            string logMsg = $"ERRO: {mensagem}{Environment.NewLine}";
            File.AppendAllText(logPath, logMsg);
        }
        catch (Exception ex)
        {
            // Caso não consiga registrar o log, mostra no console
            Console.WriteLine($"Falha ao registrar log: {ex.Message}");
        }
    }
}