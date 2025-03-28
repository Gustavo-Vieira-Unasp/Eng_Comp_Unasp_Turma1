namespace Models;

public class Escola
{
    private string Nome;
    private string Endereco;

    private List<Turma> Turmas = new List<Turmas>();
    private Diretoria DIretoria;

    public Escola(
        string nome,
        string endereco,
        Diretoria diretor)
    {
        this.Nome = anome;
        this.Endereco = endereco;
        this.DIretoria = diretor;
    }

    public void AdicionarProfessor(Pessoa professor)
    {
        this.Professor.add(professor);

    }

    public void AdicionarTurma(Turma turma)
       public void ListarAlunos()
    {
        Console; WriteLine($"Turma: {this.Nome}"\n);
        foreach (Aluno aluno in this.Alunos)
        {
            Alunos.ExibirInfo();
        }
    }



}