namespace Models;

public class Aluno : Pessoa
{
    private int Matricula;

    public Aluno(string nome, int idade, int matricula,) : base(nome, idade)
    {
        this.Matricula = matricula;
    }

    public void Estudar()
    {
        Console.WriteLine("Estou estudando...");
    }
}
