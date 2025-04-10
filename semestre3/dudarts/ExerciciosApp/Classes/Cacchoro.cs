namespace Classes;

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Auauauauaau");
    }

    public override void Dormir()
    {
        Console.WriteLine("Estou indo dormir");
    }
}