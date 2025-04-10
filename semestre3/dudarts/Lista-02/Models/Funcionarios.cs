namespace Models;

public class Funcionarios
{
    private string Nome { get; set; }
    private int Salario { get; set; }
    private int Descontos { get; set; }


    public Funcionarios(string nome, int salario, int descontos)
    {
        Nome = nome;
        Salario = salario;
        Descontos = descontos;
    }


    public float CalcularSalarioLiquido()
    {
        return Salario - Descontos;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Funcionário: {Nome}");
        Console.WriteLine($"Salário Bruto: {Salario:C}");
        Console.WriteLine($"Descontos: {Descontos:C}");
        Console.WriteLine($"Salário Líquido: {CalcularSalarioLiquido():C}");
    }
}