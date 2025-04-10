namespace Models;

public abstract class Animal
{
    private int Idade{get; set;} 
    private string Nome{get; set;} 
    
    public void EmitirSom()
    {
        Console.WriteLine("fazer barulho de animal");
    }


}