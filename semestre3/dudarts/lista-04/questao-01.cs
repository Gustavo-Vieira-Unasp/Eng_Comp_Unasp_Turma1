abstract public class Figura
{
    public float Base { get; set; }
    public float Altura { get; set; }

    public virtual void CalcularArea(float _base, float altura)
    {
        Base = _base;
        Altura = altura;

        area = _base * altura;
        Console.WriteLine(area);
    }
}

public class Retangulo : Figura { }

public class Circulo : Figura
{
    public float Raio { get; set; }
    public float Pi = 3.14;
    public override void CalcularArea(float raio)
    {
        Raio = raio;
        area = Pi * (Raio * *2);
        Console.WriteLine(area);
    }
}

