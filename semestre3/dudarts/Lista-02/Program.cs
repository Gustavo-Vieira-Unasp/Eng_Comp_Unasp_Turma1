namespace Models;
using System;

public class Program
{
    static void Main()
    {
        // Exemplo com a classe Pessoa
        Console.Write("Digite o nome da pessoa: ");
        string nomePessoa = Console.ReadLine() ?? " ";
        Console.Write("Digite a idade da pessoa: ");
        int idadePessoa = int.Parse(Console.ReadLine() ?? "0");
        
        Pessoa pessoa = new Pessoa(nomePessoa, idadePessoa);
        pessoa.ExibirDados();

        // Exemplo com a classe Aluno
        Console.Write("Digite a Nota 1 do aluno: ");
        float nota1 = float.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite a Nota 2 do aluno: ");
        float nota2 = float.Parse(Console.ReadLine() ?? "0");
        
        Aluno aluno = new Aluno(nota1, nota2);
        aluno.ExibirDados();

        // Exemplo com a classe Produto
        Console.Write("Digite o nome do produto: ");
        string nomeProduto = Console.ReadLine() ?? " ";
        Console.Write("Digite o preço do produto: ");
        float precoProduto = float.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite o estoque do produto: ");
        int estoqueProduto = int.Parse(Console.ReadLine() ?? "0");
        
        Produto produto = new Produto(nomeProduto, precoProduto, estoqueProduto);
        produto.ExibirDados();

        // Exemplo com a classe Retângulo
        Console.Write("Digite a largura do retângulo: ");
        int largura = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite a altura do retângulo: ");
        int altura = int.Parse(Console.ReadLine() ?? "0");
        
        Retangulo retangulo = new Retangulo(largura, altura);
        retangulo.ExibirDados();

        // Exemplo com a classe Temperatura
        Console.Write("Digite a temperatura em Celsius: ");
        double celsius = double.Parse(Console.ReadLine() ?? "0");
        
        Temperatura temperatura = new Temperatura();
        temperatura.Celsius = celsius;
        temperatura.ExibirTemperaturas();

        //exemplo com a classe Circulo
        Console.Write("Digite o valor do raio do círculo: ");
        float raio = float.Parse(Console.ReadLine() ?? "0");

        Circulo circulo = new Circulo(raio);
        circulo.ExibirDados();
        
        // Exemplo com a classe ContaBancaria
        Console.Write("Digite o saldo inicial da conta: ");
        int saldoInicial = int.Parse(Console.ReadLine() ?? "0");
        
        ContaBancaria conta = new ContaBancaria(saldoInicial);
        conta.ExibirSaldo();
        Console.Write("Digite o valor a ser sacado: ");
        int valorSaque = int.Parse(Console.ReadLine() ?? "0");
        conta.Sacar(valorSaque);

        // Exemplo com a classe CadastrarUsuarios
        Console.Write("Digite o nome do usuário: ");
        string nomeUsuario = Console.ReadLine() ?? " ";
        Console.Write("Digite a senha do usuário (mínimo 8 caracteres): ");
        string senhaUsuario = Console.ReadLine() ?? " ";

        CadastrarUsuarios usuario = new CadastrarUsuarios(nomeUsuario, senhaUsuario);
        usuario.ExibirDados();
    }
}