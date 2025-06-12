namespace Models;

public class Conta
{
    private string Nome;
    private string Senha;

    public Conta(string nome, string senha)
    {
        if (senha.Length < 8)
        {
            throw new ArgumentException("A senha deve possuir mais de 8 caracteres");
        }
        Nome = nome;
        Senha = senha;
    }
}