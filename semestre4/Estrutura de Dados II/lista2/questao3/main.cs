using System;
using System.Collections.Generic;

public struct Item
{
    public int Id;
    public string Nome;
    public double Preco;
    public int Quantidade;
}

public class GerenciadorInventario
{
    private Dictionary<int, Item> inventario;
    private int proximoId = 1;

    public GerenciadorInventario()
    {
        inventario = new Dictionary<int, Item>();
    }

    public void AdicionarItem(string nome, double preco, int quantidade)
    {
        Item novoItem = new Item
        {
            Id = proximoId++,
            Nome = nome,
            Preco = preco,
            Quantidade = quantidade
        };
        inventario.Add(novoItem.Id, novoItem);
        Console.WriteLine($"Item '{novoItem.Nome}' adicionado com sucesso. ID: {novoItem.Id}");
    }

    public void AtualizarQuantidade(int itemId, int novaQuantidade)
    {
        if (inventario.TryGetValue(itemId, out Item itemParaAtualizar))
        {
            itemParaAtualizar.Quantidade = novaQuantidade;
            inventario[itemId] = itemParaAtualizar;
            Console.WriteLine($"Quantidade do item '{itemParaAtualizar.Nome}' (ID: {itemId}) atualizada para {novaQuantidade}.");
        }
        else
        {
            Console.WriteLine($"Erro: Item com ID {itemId} não encontrado.");
        }
    }

    public void AtualizarPreco(int itemId, double novoPreco)
    {
        if (inventario.TryGetValue(itemId, out Item itemParaAtualizar))
        {
            itemParaAtualizar.Preco = novoPreco;
            inventario[itemId] = itemParaAtualizar;
            Console.WriteLine($"Preço do item '{itemParaAtualizar.Nome}' (ID: {itemId}) atualizado para {novoPreco:C}.");
        }
        else
        {
            Console.WriteLine($"Erro: Item com ID {itemId} não encontrado.");
        }
    }

    public void ListarItens()
    {
        Console.WriteLine("\n--- Inventário Atual ---");
        if (inventario.Count == 0)
        {
            Console.WriteLine("O inventário está vazio.");
            return;
        }

        foreach (var item in inventario.Values)
        {
            Console.WriteLine($"ID: {item.Id}, Nome: {item.Nome}, Preço: {item.Preco:C}, Quantidade: {item.Quantidade}");
        }
        Console.WriteLine("------------------------\n");
    }

    public static void Main(string[] args)
    {
        GerenciadorInventario gerenciador = new GerenciadorInventario();

        gerenciador.AdicionarItem("Teclado Mecânico", 150.00, 20);
        gerenciador.AdicionarItem("Mouse Sem Fio", 75.50, 50);

        gerenciador.ListarItens();

        gerenciador.AtualizarQuantidade(2, 45);

        gerenciador.AtualizarPreco(1, 145.90);
        
        gerenciador.ListarItens();

        gerenciador.AtualizarQuantidade(99, 10);
    }
}