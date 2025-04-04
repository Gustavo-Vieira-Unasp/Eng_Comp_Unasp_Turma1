namespace Util;
using Models;

public class BancoDeDados
{
    public List<Professor> Professores = new List<Professor>();
    public List<Aluno> Alunos = new List<Aluno>();

    public void CadastrarProfessor()
    {
        Console.WriteLine("Cadastrar professor");
        Console.WriteLine("Digite o nome do Professor");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a idade do Professor");
        int idade = Console.ReadLine();
        Console.WriteLine("Digite a diciplina do Professor");
        string diciplina = Console.ReadLine();
        Professor professor = new Professor(nome, idade, diciplina);
        this.Professsores.Add(professor);
    }

    public void CadastrarAluno()
    {
        Console.WriteLine("Cadastrar aluno");
        Console.WriteLine("Digite nome do aluno");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite idade do aluno");
        int idade = Console.ReadLine();
        Console.WriteLine("Digite matricula do aluno");
        int matricula = Console.ReadLine();
        Aluno aluno = new Aluno(nome, idade, matricula);
        this.Aluno.Add(aluno);
    }

    public void CadastrarDiretor()
    {
        Console.WriteLine("Cadastrar diretor");
        Console.WriteLine("Escolha o professor");
        this.ListarProfessores();
        Console.ReadKey();
    }

    public void ListarProfessores()
    {
        int i = 0;
        foreach (Professor professor in this.Professores)
        {
            Console.Write($"{(i++)}");
            professor.ExibirInfo();
        }
    }
}