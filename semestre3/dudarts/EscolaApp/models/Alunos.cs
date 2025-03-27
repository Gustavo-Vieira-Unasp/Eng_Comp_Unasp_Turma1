namespace Models;


public class Aluno : Pessoa
{
    private int Matricula;

    public Aluno(int Matricula; string Nome; int Idade) : Base(Nome, Idade)
    {
        this.Matricula = Matricula;
    }
    public void Estudar()
    {
        Console.WriteLine("Estudando barril....."); 
    }
    
}