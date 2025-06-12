namespace Exercicios;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Models.Aluno;
//Criar um sistema que grave e leia objetos Aluno em um arquivo JSON.

public class SistemaAlunoJson
{
    private string caminhoArquivo;

    public SistemaAlunoJson(string caminhoArquivo)
    {
        this.caminhoArquivo = caminhoArquivo;
    }

    // Grava uma lista de alunos no arquivo JSON
    public void GravarAlunos(List<Aluno> alunos)
    {
        try
        {
            string json = JsonSerializer.Serialize(alunos);
            File.WriteAllText(caminhoArquivo, json);
            Console.WriteLine("Alunos gravados com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao gravar alunos: {ex.Message}");
        }
    }

    // Lê a lista de alunos do arquivo JSON
    public List<Aluno> LerAlunos()
    {
        try
        {
            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("Arquivo não encontrado.");
                return new List<Aluno>();
            }
            string json = File.ReadAllText(caminhoArquivo);
            return JsonSerializer.Deserialize<List<Aluno>>(json) ?? new List<Aluno>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler alunos: {ex.Message}");
            return new List<Aluno>();
        }
    }
}