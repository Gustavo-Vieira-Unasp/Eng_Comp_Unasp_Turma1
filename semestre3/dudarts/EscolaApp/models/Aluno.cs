namespace Models;

public class Aluno : Pessoa
{
    private int Matricula;

    public Aluno(int matricula, string nome, int idade) : base(nome, idade)
    {
        this.Matricula = matricula;
    }

    public void Estudar()
    {
        Console.WriteLine("Estou estudando...");
    }
}
