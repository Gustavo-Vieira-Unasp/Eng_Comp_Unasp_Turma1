namespace Models;
public class ContaBancaria
{
    public int Saldo{get; set;}

    public ContaBancaria(int saldo)
    {
        Saldo = (saldo > 0 ? saldo : 0);
    }
    public void Sacar(int valor)
    {
        if (valor > 0)
        {
            if (valor < Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso");
            }
            else
            {
                Console.WriteLine($"saque de {valor} nao permitido, saldo insuficiente");
            }
        }
        else
        {
            Console.WriteLine("O saque deve ser positivo");
        }
    }

}