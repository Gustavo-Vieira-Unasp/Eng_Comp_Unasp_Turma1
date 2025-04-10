namespace Models;
using System;

public class CadastrarUsuarios
{

    private string nome;
    private string senha;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value)) 
                nome = value;
            else
                Console.WriteLine("Nome não pode ser vazio.");
        }
    }


    public string Senha
    {
        get { return senha; }
        set
        {
            if (value.Length >= 8)
                senha = value;
            else
                Console.WriteLine("A senha deve ter pelo menos 8 caracteres.");
        }
    }

    // Construtor
    public CadastrarUsuarios(string nome, string senha)
    {
        Nome = nome;
        Senha = senha;
    }


    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine("Senha: *****");
    }
}