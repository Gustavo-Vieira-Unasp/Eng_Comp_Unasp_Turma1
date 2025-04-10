namespace Models;
using System;

public class Pessoa
{
    private string Nome { get; set; }
    private int Idade { get; set; }


    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }


    public int IdadeEmAnos()
    {
        return Idade * 12;
    }

    public int IdadeEmDias()
    {
        return Idade * 365;
    }


    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine($"Sua idade em meses: {IdadeEmAnos()}");
        Console.WriteLine($"Sua idade em dias: {IdadeEmDias()}");
    }
}