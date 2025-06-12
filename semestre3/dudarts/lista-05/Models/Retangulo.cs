namespace Models;

public class Retangulo
{
    private int Altura { get; set;}
    private int Largura { get; set;}
    public int Area;

    public Retangulo(int altura, int largura)
    {
        Altura=altura;
        Largura=largura;
    }

}