namespace Classes;

public abstract class animal
{
    protected string nome;

    private int idade;

    public string Nome
    {
        get { return this.nome; }
        set { this.nome = value; }
    }

    public int Idade { get; set; }
    public void ExibirNome(){
        Console.WriteLine(this.Nome;)
    }

    public abstract void EmitirSom()
    {
        Console.WriteLine("Fazer Barulho");
    }

    public void Comer()
    {
        Console.WriteLine("Estou comendo");
    }

    public abstract void Dormir() { }
}
