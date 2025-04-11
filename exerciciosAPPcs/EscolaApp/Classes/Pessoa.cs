namespace Classes;

public class Pessoa{

    public string Nome{get; set;}

    public int Idade
    {   
        get { return this.Idade; }
        set{
            if (value > 0) && (value <= 100)
            {
                this.Idade = value; 
            }
            else
            {
                Console.WriteLine("Idade Inválida");
            }
        }
    } 

    public void Exibir (){
        Console.WriteLine("==================");
        Console.WriteLine($"Nome: {this.Name}");
        Console.WriteLine($"Idade: {this.Idade}");
        Console.WriteLine("==================");
    }
}