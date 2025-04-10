using System;

class Notas
{
    static char ObterNota(int nota1, int nota2, int nota3)
    {
        // Calcula a média das três notas
        double media = (nota1 + nota2 + nota3) / 3.0;

        // Retorna a letra correspondente à média
        if (media >= 90)
        {
            return 'A';
        }
        else if (media >= 80)
        {
            return 'B';
        }
        else if (media >= 70)
        {
            return 'C';
        }
        else if (media >= 60)
        {
            return 'D';
        }
        else
        {
            return 'F';
        }
    }

    static void Main()
    {
        // Exemplo de uso
        int nota1 = 85, nota2 = 90, nota3 = 78;
        char resultado = ObterNota(nota1, nota2, nota3);
        Console.WriteLine(resultado); 
    }
}
