namespace Models;

public class Contabancaria
{
    private float Saldo;

    public Contabancaria(float saldo)
    {
        Saldo = (saldo >= 0 ? saldo : 0);
    }
}