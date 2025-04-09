namespace Models;
using System;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public int IdadeEmAnos()
    {
        return Idade * 12;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine($"Sua idade em meses: {IdadeEmAnos()}");
    }
}