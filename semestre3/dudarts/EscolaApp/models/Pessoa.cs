namespace Models;
public class Pessoa
{
    private string Nome;
    private int Idade;

    public Pessoa(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Nome: {this.Nome}");
        Console.WriteLine($"Idade: {this.Idade}");
    }

}