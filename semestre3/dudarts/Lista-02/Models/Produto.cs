namespace Models;

public class Produto
{
    private string Nome { get; set; }
    private float Preco { get; set; }
    private int Estoque { get; set; }


    public Produto(string nome, float preco, int estoque)
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }


    public void ExibirDados()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Preço: {Preco:C}");
        Console.WriteLine($"Estoque: {Estoque} unidades");
    }
}