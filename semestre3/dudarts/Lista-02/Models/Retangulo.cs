namespace Models;

public class Retangulo
{
    private int Largura { get; set; }
    private int Altura { get; set; }


    public Retangulo(int largura, int altura)
    {
        Largura = largura;
        Altura = altura;
    }


    public int CalcularArea()
    {
        return Largura * Altura;
    }


    public void ExibirDados()
    {
        Console.WriteLine($"Largura: {Largura} unidades");
        Console.WriteLine($"Altura: {Altura} unidades");
        Console.WriteLine($"Área: {CalcularArea()} unidades quadradas");
    }
}