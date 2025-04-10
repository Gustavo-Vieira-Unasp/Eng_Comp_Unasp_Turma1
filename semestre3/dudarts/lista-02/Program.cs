using System;
using Models;

class Program
{
    public void IdadeEmDias()
    {
        void RecebeAnos()
        {
            int AnosVividos = Int32.Parse(Console.ReadLine() ?? "0");
            int DiasCompletos = AnosVividos * 365;
            Console.WriteLine($"Você viveu {DiasCompletos} dias baseados nos seus anos completos");
        }
    }

    public void CalcularRetangulo()
    {
        Console.WriteLine("Digite a altura");
        int Altura = Int32.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Digite a largura");
        int Largura = Int32.Parse(Console.ReadLine() ?? "0");

        Retangulo retangulo = new Retangulo(Altura, Largura);
        int area = Largura*Altura;
        retangulo.Area = area;
        Console.WriteLine($"A área do seu retângulo é {area}");
    }

    public void CadastrarPessoa()
    {
        Console.WriteLine("Digite um nome de usuário: ");
        string NomeUsuario = Console.ReadLine();
        Console.WriteLine("Digite sua senha: ");
        string SenhaUsuario = Console.ReadLine();
        Conta conta = new Conta(NomeUsuario, SenhaUsuario);
    }
}