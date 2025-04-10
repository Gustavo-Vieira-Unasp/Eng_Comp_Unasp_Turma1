using System;

class Media
{
    static bool MelhorQueAMedia(int[] pontuacoes, int minhaPontuacao)
    {
        // Calcula a soma de todas as pontuações dos colegas
        int soma = 0;
        foreach (var pontuacao in pontuacoes)
        {
            soma += pontuacao;
        }
        
        // Calcula a média dos colegas
        double media = soma / (double)pontuacoes.Length;
        
        // Compara se a minha pontuação é maior que a média
        return minhaPontuacao > media;
    }

    static void Main()
    {
        // Exemplo de uso
        int[] pontuacoes = { 70, 80, 90, 85, 75 };  // Pontuações dos colegas
        int minhaPontuacao = 88;  // Sua pontuação

        bool resultado = MelhorQueAMedia(pontuacoes, minhaPontuacao);
        Console.WriteLine(resultado);  // Saída: true (se sua pontuação for maior que a média dos colegas)
    }
}