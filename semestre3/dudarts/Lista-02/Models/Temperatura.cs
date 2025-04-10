namespace Models;
using System;

public class Temperatura
{
    private double celsius;
    private double fahrenheit;

    public double Celsius
    {
        get { return this.celsius; }
        set
        {
            celsius = value;
            fahrenheit = (celsius * 9 / 5) + 32;
        }
    }

    public double Fahrenheit
    {
        get { return this.fahrenheit; }
        set
        {
            fahrenheit = value;
            celsius = (fahrenheit - 32) * 5 / 9;
        }
    }

    public void ExibirTemperaturas()
    {
        Console.WriteLine($"Temperatura em Celsius: {Celsius:F2}°C");
        Console.WriteLine($"Temperatura em Fahrenheit: {Fahrenheit:F2}°F");
    }
}