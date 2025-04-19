from libs.menu import *

def processar():
    while True:
        opcao = menu()
        if opcao == '1':
            novos_chamados()
        elif opcao == '2':
            buscar_chamado()
        elif opcao == '3':
            status_finalizado()
        elif opcao == '4':
            qual_prioridade()
        elif opcao == '5':
            exibir_estatisticas()
        elif opcao == '6':
            qual_limpeza()
        else:
            print("Opção inválida, por favor, tente novamente.")

if __name__ == "__main__":
    processar()
