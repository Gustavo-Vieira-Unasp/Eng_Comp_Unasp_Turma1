using System.Reflection.PortableExecutable;

namespace Models;
public class Carro : Veiculo{
    public string Cor {get; set; }
    public Carro(string marca, int ano, string cor) : base(marca, ano){
        this.Cor = cor;
    }
    public override void ExibirInformacoes()
    {
        throw new NotImplementedException();
    }
}