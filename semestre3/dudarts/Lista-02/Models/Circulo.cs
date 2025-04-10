namespace Models;
using System;

public class Circulo
{
    private float Raio { get; set; }


    public Circulo(float raio)
    {
        if (raio > 0)
        {
            Raio = raio;
        }
        else
        {
            Console.WriteLine("O raio deve ser maior que zero.");
        }
    }

    public double Area()
    {
        return Math.PI * Math.Pow(Raio, 2);
    }


    public void ExibirDados()
    {
        Console.WriteLine($"Raio: {Raio}");
        Console.WriteLine($"Área: {Area():F2}");
    }
}