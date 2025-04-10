using System;

class Relogio
{
    static int TempoEmMilissegundos(int h, int m, int s)
    {
        return (h * 3600000) + (m * 60000) + (s * 1000);
    }

    static void Main()
    {
        int h = 0;
        int m = 1; 
        int s = 1;
        int resultado = TempoEmMilissegundos(h, m, s);
        Console.WriteLine(resultado); // Saída: 61000
    }
}