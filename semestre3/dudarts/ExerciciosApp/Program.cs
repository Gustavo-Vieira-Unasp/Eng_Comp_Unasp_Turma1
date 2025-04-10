using System.Net;
using Classes;
using Utilitarios;

string nome = Util.ReceberDados("Digite o nome do cacchoro");
int idade = Int32.Parse(Util.ReceberDados("Qual idade dele?"));

Cachorro cachorro = new Cachorro();
cachorro.Nome = nome;
cachorro.Idade = idade;