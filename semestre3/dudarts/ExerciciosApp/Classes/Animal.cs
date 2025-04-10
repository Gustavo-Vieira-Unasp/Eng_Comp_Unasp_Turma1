namespace Classes;

public class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void EmitirSom()
    {
        Console.WriteLine("Fazer algum barulho");
    }
}