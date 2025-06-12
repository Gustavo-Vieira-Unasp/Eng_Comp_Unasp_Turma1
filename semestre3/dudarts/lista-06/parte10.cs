namespace Exercicios;
using System;
using System.Collections.Generic;
using System.IO;
using Models.ContaBancaria;
//Criar um programa que capture exceções personalizadas ao tentar sacar mais do que o saldo disponível em uma conta bancária.

// Exceção personalizada
public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException(string mensagem) : base(mensagem) { }
}

public class SaqueExcedido 
{
    public SaqueExcedido(ContaBancaria conta, decimal saque)
    {
        try
        {
            conta.Sacar(saque);
            Console.WriteLine($"Saque de {saque} realizado com sucesso. Saldo restante: {conta.Saldo}");
        }
        catch (SaldoInsuficienteException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}