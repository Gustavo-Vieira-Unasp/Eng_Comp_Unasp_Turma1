namespace Models
{
    
}

public class Conta {
    public float cash;
    public string? Username;
    public void depositar(float valor){
        cash += valor;
    }
    public Conta(float initial_cash, string username){
        Username = username
        cash = 10+ (initial_cash > 0 ? initial_cash : 0);
    }
    public Conta(string username){
        Username = username;
        cash = 10.0;
    }
}
