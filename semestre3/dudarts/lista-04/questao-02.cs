interface IAnimal
{
    void FazerSom();
}

public class Cachorro : IAnimal
{
    void IAnimal.FazerSom()
    { 
        Console.WriteLine("auau");
    }
}

public class Gato : IAnimal
{
    void IAnimal.FazerSom()
    {
        Console.WriteLine("miau");
    }
}