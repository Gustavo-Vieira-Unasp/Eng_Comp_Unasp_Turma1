using System;

public class Cliente
{
    public string Nome;
    public string Email;
    public string Telefone;
}

public class GerenciadorCliente
{
    public static void AlterarDadosCliente(ref Cliente cliente)
    {
        Console.WriteLine("\n--- Alterando dados do cliente ---");

        Console.Write($"Novo nome (atual: {cliente.Nome}): ");
        string novoNome = Console.ReadLine();
        if (!string.IsNullOrEmpty(novoNome))
        {
            cliente.Nome = novoNome;
        }

        Console.Write($"Novo email (atual: {cliente.Email}): ");
        string novoEmail = Console.ReadLine();
        if (!string.IsNullOrEmpty(novoEmail))
        {
            cliente.Email = novoEmail;
        }

        Console.Write($"Novo telefone (atual: {cliente.Telefone}): ");
        string novoTelefone = Console.ReadLine();
        if (!string.IsNullOrEmpty(novoTelefone))
        {
            cliente.Telefone = novoTelefone;
        }

        Console.WriteLine("\nDados alterados com sucesso!");
    }

    public static void ExibirDadosCliente(Cliente cliente)
    {
        Console.WriteLine("\n--- Dados do Cliente ---");
        Console.WriteLine($"Nome: {cliente.Nome}");
        Console.WriteLine($"Email: {cliente.Email}");
        Console.WriteLine($"Telefone: {cliente.Telefone}");
        Console.WriteLine("------------------------\n");
    }

    public static void Main(string[] args)
    {
        Cliente meuCliente = new Cliente
        {
            Nome = "João Silva",
            Email = "joao.silva@email.com",
            Telefone = "11987654321"
        };

        Console.WriteLine("Dados do cliente antes da alteração:");
        ExibirDadosCliente(meuCliente);

        AlterarDadosCliente(ref meuCliente);

        Console.WriteLine("Dados do cliente após a alteração:");
        ExibirDadosCliente(meuCliente);
    }
}