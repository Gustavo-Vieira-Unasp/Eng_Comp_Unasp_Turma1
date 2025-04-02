using System;

class program
{
// Somatorio
public void Somatorio()
{
    void receber_numeros()
    {
        int numero_inicial = Int32.Parse(Console.ReadLine());
        while (numero_inicial <= 0)
        {
            Console.WriteLine("O número deve ser maior que 0");
            numero_inicial = Int32.Parse(Console.ReadLine());
        }
        
        if (numero_inicial == 1)
        {
            return;
        }

        else
        {
            List<int> sequencia = new List<int>();
            for (int i = 1; i <= numero_inicial; i++)
            {
                sequencia.Add(i);
            }
            int numero_final = 0;
            
            foreach (int numero in sequencia)
            {
                numero_final += numero;
            }

            string sequencia_somatoria = "(" + string.Join(" + ", sequencia) + ")";

            string resposta_final = $"{numero_inicial} -> {numero_final} {sequencia_somatoria}";
        }
    }
}

// Relogio
public void Relogio()
{
    void receber_tempo()
    {
        int hora = Int32.Parse(Console.ReadLine());
        while (hora < -1 && hora > 23)
        {
            Console.WriteLine("Valor de hora negativos ou superiores a um dia não são aceitos");
            hora = Int32.Parse(Console.ReadLine());
        }

        int minuto = Int32.Parse(Console.ReadLine());
        while (minuto < -1 && minuto > 59)
        {
            Console.WriteLine("Valor de minuto negativo ou superior a 60 não são aceitos");
            minuto = Int32.Parse(Console.ReadLine());
        }        

        int segundo = Int32.Parse(Console.ReadLine());
        while (segundo < -1 && segundo > 59)
        {
            Console.WriteLine("Valor de segundo negativo ou superior a 60 não são aceitos");
            segundo = Int32.Parse(Console.ReadLine());
        }

        int segundos = (hora*3600) + (minuto*60) + segundo;
        int milisegundos = segundos * 1000;
    }
}


// Livro de Notas
public void Livro_Notas()
{
    void receber_nota()
    {
        int nota = Int32.Parse(Console.ReadLine());

        if (nota >= 90 && nota <= 100)
        {
            Console.WriteLine("Parabéns, você tirou A!!!");
        }

        else if (nota >= 80 && nota < 90)
        {
            Console.WriteLine("Parabéns, você tirou B!!");
        }

        else if (nota >= 70 && nota < 80)
        {
            Console.WriteLine("Parabéns, você tirou C!");
        }

        else if (nota >= 60 && nota < 70)
        {
            Console.WriteLine("Mais sorte na próxima, você tirou D");
        }

        else
        {
            Console.WriteLine("Sinto muito, você tirou F");
        }
    }
}
}