// See https://aka.ms/new-console-template for more information
using Modelos;
using Util;

BancoDeDados banco = BancoDeDados();

while(true)
{
    Menu.exibir();
    switch(opcao)
    {
        case 1:
            banco.CadastrarProfessors();
            break;
        case 2:
            banco.CadastrarAluno();
            break;
        case 3:
            banco.CadastrarDiretor();
            break;
        default:
            return;
    }
}