namespace Models;
class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    public Carro(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    public void Ligar()
    {
        Console.WriteLine("O carro está ligado");
    }
}