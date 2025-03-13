namespace Models;
public abstract class Veiculo{
    private string marca;
    private string modelo;
    private int anoFabricacao;

    public string Marca{
        get{
            return this.marca;
        }
        set{
            if (value.Length >= 3){
              this.marca = "Marca: " + value;
            }
        }
    }

    public Veiculo(string marca, int ano) {
        this.Marca = marca;
        this.Ano = ano;
    }

    public int Ano{
        get; 
        set {
            if (value >= 1900) 
            this.Ano = value;
        }
    }

    public abstract void ExibirInformacoes();
}