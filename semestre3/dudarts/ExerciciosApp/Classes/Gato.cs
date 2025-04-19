using Interfaces;
namespace Classes;

public class Gato : IAnimal
{
    private bool EstaDormindo { get; set; }
    public override void EmitirSom()
    {
        Console.WriteLine("Miau miau");
    }

    public override void Dormir()
    {
        Console.WriteLine("Estou indo dormir");
    }
    public void IrDormir()
    {

        Console.WriteLine("Ir dormir");
    }
}