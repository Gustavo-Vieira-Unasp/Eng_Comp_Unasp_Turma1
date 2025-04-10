namespace Classes;

public class Animal
{
    public string nome;
    public int idade;

    public string Nome
    {
        get { return this.nome;}
        set {
            this.nome = value;
        }
    }
    public int Idade 
    {
        get {return this.idade;}
        set {
            this.idade = value;
        }
    }

    public Animal(string nome, int idade)
    {
        nome = nome;
        idade = idade;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Fazer algum barulho");
    }

    public void Comer()
    {
        Console.WriteLine("Estou me alimentando");
    }

    public abstract void Dormir() { }

    public void ExibirNome()
    {
        Console.WriteLine(this.Nome);
    }
}