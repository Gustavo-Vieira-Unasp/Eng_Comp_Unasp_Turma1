namespace Models;


public class Diretoria 
{
    private Professor Diretoria;
    public Diretoria(Professor diretor)
    {
        this.Diretor = diretor;
    }

    public void ExibirDiretor() 
    {
        this.Diretor.ExibirInfo();
    }

}