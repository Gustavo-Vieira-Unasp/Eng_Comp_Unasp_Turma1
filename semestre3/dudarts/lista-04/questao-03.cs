interface IVeiculo
{
    void Acelerar();
    void Freiar();
}

public class Cachorro : IVeiculo
{
    void IVeiculo.Acelerar()
    {
        Console.WriteLine("Vrom vrom");
    }

    void IVeiculo.Freiar()
    {
        Console.WriteLine("riiiiiihhh");
    }
}

public class Gato : IVeiculo
{
    void IVeiculo.Acelerar()
    {
        Console.WriteLine("from from");
    }

    void IVeiculo.Freiar()
    {
        Console.WriteLine("ihhhhhh");
    }
}