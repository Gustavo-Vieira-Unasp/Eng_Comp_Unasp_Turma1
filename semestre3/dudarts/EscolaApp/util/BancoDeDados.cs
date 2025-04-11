namespace Util;
using Modelos;

public class BancoDeDados
{
    public List<Professor> Professores = new List<Professor>();
    public List<Aluno> Alunos = new List<Aluno>();
    public List<Diretoria> Diretorias = new List<Diretoria>();
    
    public void CadastrarProfessor()
    {
        Console.WriteLine("Escolheu cadastrar Professor")
        Console.WriteLine("Digite o nome do professor: ")
        string name = Console.ReadLine();
        Console.WriteLine("Digite a idade do professor: ")
        int idade = Console.ReadLine();
        Console.WriteLine("Digite a diciplina do professor: ")
        string diciplina = Console.ReadLine();
        Professor professor = new Professor(nome, idade, diciplina);
        this.Professores.Add(professor)
            
    }
     public void CadastrarAluno()
    {
        Console.WriteLine("Escolheu cadastrar ALuno")
        Console.WriteLine("Digite o nome do ALuno: ")
        string name = Console.ReadLine();
        Console.WriteLine("Digite a idade do ALuno: ")
        int idade = Console.ReadLine();
        Console.WriteLine("Digite a Matricula do ALuno: ")
        int matricula = Console.ReadLine();
        Alunos aluno = new Professor(nome, idade, matricula);
        this.Alunos.Add(aluno)
    }
     public void CadastrarDiretor()
    {
        Console.WriteLine("Escolheu cadastrar Diretor")
        Console.WriteLine("Escolheu cadastrar Professor")
        this.ListarProfessores();
        Console.Readkey();
    }
    public void ListarProfessores()
    {
        foreach (Professor professor in this.Professores)
        {
            Console.Write($"{(i++)}")
            professor.ExibirInfo();
        }
    }

}