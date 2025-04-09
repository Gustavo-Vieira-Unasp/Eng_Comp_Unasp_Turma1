namespace Models;

public class Pessoa
{
    private string Nome { get; set; }
    private int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome=nome;
        Idade=idade;
    }

}