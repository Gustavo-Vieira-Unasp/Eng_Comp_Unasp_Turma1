namespace Models;

public class Aluno
{
    private float Nota1 { get; set; }
    private float Nota2 { get; set; }


    public Aluno(float nota1, float nota2)
    {
        Nota1 = nota1;
        Nota2 = nota2;
    }


    public float Media()
    {
        return (Nota1 + Nota2) / 2;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nota 1: {Nota1}");
        Console.WriteLine($"Nota 2: {Nota2}");
        Console.WriteLine($"Média: {Media():F2}");
    }
}