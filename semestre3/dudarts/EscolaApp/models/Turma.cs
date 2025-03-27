namespace Models;

public class Turma
{
    private string Nome;
    private List<Aluno> Alunos = new List<Aluno>();
    private List<Professor> Professores = new List<Professor>();

    public Turma(string nome) => this.Nome = nome;
}