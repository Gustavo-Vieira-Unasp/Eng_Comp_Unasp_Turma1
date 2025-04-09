using System.Dynamic;

namespace Models;

public class Produto
{
    private string Nome { get; set; }
    private int Preco { get; set; }
    private int Estoque { get; set; }

    public Produto(string nome, int preco, int estoque)
    {
        Nome=nome;
        Preco=preco;
        Estoque=estoque;
    }
}