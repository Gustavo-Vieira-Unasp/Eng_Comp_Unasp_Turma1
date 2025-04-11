namespace Classes;

public class Cachorro : Animal
{
    public Cachorro(string nome, int idade ) : base(nome, idade){ }
    public void EmitirNome(){
        Console.WriteLine(base.nome);
    }
    
    public override void EmitirSom()
    {
        Console.WriteLine("Auauauauau, au");
    }
    public override void Dormir(){
        Console.WriteLine("Estou indo dormir, do dia foi barril")
    }
}
