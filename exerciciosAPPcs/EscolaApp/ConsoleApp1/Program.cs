using Classes;
using Utilitarios;

string nome = Util.ReceberDados("Digite teu nome: ")
int idade = Int32.Parse(Util.ReceberDados("Digite sua idade: "))

Cachorro cachorro = new Cachorro(Nome; Idade;);



cachorro.Nome= nome;
cachorro.Idade = idade;
cachorro.EmitirSom();
cachorro.Comer();

Console.ReadKey();