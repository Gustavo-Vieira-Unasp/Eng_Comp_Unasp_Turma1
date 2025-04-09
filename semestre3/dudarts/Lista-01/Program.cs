using Models;
using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine() ?? " ";

        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine() ?? "0");

        Pessoa pessoa = new Pessoa(nome, idade);
        
       pessoa.ExibirDados();
        
        Console.ReadLine();



        Carro carro1 = new Carro("Fiat", "Uno", 2020);
        Carro carro2 = new Carro("Chevrolet", "Onix", 2021);

        Console.WriteLine($"Carro 1: Marca = {carro1.Marca}, Modelo = {carro1.Modelo}, Ano = {carro1.Ano}");
        Console.WriteLine($"Carro 2: Marca = {carro2.Marca}, Modelo = {carro2.Modelo}, Ano = {carro2.Ano}");

        carro1.Ligar();
        carro2.Ligar();



        Livro livro1 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954);

        livro1.ExibirDadosLIvro();


        Console.WriteLine("digite o seu saldo: ");
        int SaldoRecebido = Int32.Parse(Console.ReadLine() ?? "0");
        ContaBancaria contabancaria = new ContaBancaria(SaldoRecebido);
        Console.WriteLine("Digite seu saque: ");
        int SaqueConta = Int32.Parse(Console.ReadLine() ?? "0");
        contabancaria.Sacar(SaqueConta);
    }

}

//Comentario legal