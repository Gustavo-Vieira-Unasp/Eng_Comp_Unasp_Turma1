namespace Models;
public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }

    public Livro(string titulo, string autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
    }

    public void ExibirDadosLIvro()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Ano: " + Ano);
    }
}