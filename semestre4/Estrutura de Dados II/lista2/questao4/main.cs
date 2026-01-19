using System;

public class SimulacaoPonteiro
{
    private int[] memoria;

    public SimulacaoPonteiro(int tamanho)
    {
        memoria = new int[tamanho];
    }

    public void InicializarMemoria()
    {
        for (int i = 0; i < memoria.Length; i++)
        {
            memoria[i] = i * 10;
        }
    }

    public void ExibirMemoria()
    {
        Console.WriteLine("--- Conteúdo da Memória ---");
        for (int i = 0; i < memoria.Length; i++)
        {
            Console.WriteLine($"Endereço (Índice): {i}, Valor: {memoria[i]}");
        }
        Console.WriteLine("----------------------------");
    }

    public int LerValor(int ponteiro)
    {
        if (ponteiro >= 0 && ponteiro < memoria.Length)
        {
            return memoria[ponteiro];
        }
        else
        {
            throw new IndexOutOfRangeException("Ponteiro inválido. Fora dos limites da memória.");
        }
    }

    public void EscreverValor(int ponteiro, int novoValor)
    {
        if (ponteiro >= 0 && ponteiro < memoria.Length)
        {
            memoria[ponteiro] = novoValor;
            Console.WriteLine($"Novo valor '{novoValor}' escrito no endereço (índice) {ponteiro}.");
        }
        else
        {
            throw new IndexOutOfRangeException("Ponteiro inválido. Fora dos limites da memória.");
        }
    }

    public static void Main(string[] args)
    {
        SimulacaoPonteiro simulador = new SimulacaoPonteiro(5);

        simulador.InicializarMemoria();
        simulador.ExibirMemoria();

        int ponteiro1 = 2; 
        int valorLido = simulador.LerValor(ponteiro1);
        Console.WriteLine($"\nLendo o valor do ponteiro {ponteiro1}: {valorLido}");

        int ponteiro2 = 4;
        int novoValor = 999;
        simulador.EscreverValor(ponteiro2, novoValor);

        simulador.ExibirMemoria();

        try
        {
            int ponteiroInvalido = 10;
            simulador.LerValor(ponteiroInvalido);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"\nErro ao tentar usar um ponteiro inválido: {ex.Message}");
        }
    }
}