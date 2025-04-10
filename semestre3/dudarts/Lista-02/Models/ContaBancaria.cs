namespace Models;
using System;

public class ContaBancaria
{
    private int Saldo { get; set; }

    public ContaBancaria(int saldo)
    {
        Saldo = (saldo > 0 ? saldo : 0);
    }

    public void Sacar(int valor)
    {
        if (valor > 0)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso");
            }
            else
            {
                Console.WriteLine($"Saque de {valor} não permitido, saldo insuficiente");
            }
        }
        else
        {
            Console.WriteLine("O saque deve ser positivo");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo disponível: {Saldo:C}");
    }
}