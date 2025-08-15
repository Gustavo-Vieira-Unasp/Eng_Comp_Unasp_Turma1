static int busca_binaria(int[] vetor, int valor)
{
    int tamanho = vetor.Length;
    int metade = (int)tamanho / 2;
    int meio = vetor[metade];

    Console.WriteLine(meio);

    if (meio == valor)
        return meio;
    else
    {
        if (meio > valor)
            return busca_binaria(vetor[0..metade], valor);
        else
            return busca_binaria(vetor[metade..(tamanho - 1)], valor);
    }
}