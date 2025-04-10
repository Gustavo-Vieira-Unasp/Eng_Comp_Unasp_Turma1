namespace Models;
using System;

public class Program
{
    static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro();
        Cachorro.Nome = nome;
        Cachorro.Idade = idade;
        Cachorro.EmitirSom();

        Console.ReadKey();
    }
}