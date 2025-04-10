namespace Classes;

public class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Miau miau");
    }

    public override void Dormir()
    {
        Console.WriteLine("Estou indo dormir");
    }
}