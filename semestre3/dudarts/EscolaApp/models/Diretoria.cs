namespace Models;

public class Diretoria 
{
    private Professor Diretor;
    public Diretoria(Professor diretor)
    {
        this.Diretor = diretor;
    }

    public void ExibirDiretor() 
    {
        this.Diretor.ExibirInfo();
    }
}