from libs.cleaner import *
from libs.finished import *
from libs.priority import *
from libs.register import *
from libs.search import *
from libs.statistics import *

def menu():
    while True:
        opcao = input(
'''
GERENCIADOR DE CHAMADOS
1. Registrar chamado
2. Procurar chamado
3. Finalizar chamado
4. Gerenciar prioridade
5. Exibir estatísticas
6. Limpar lista
'''
        )
        if opcao == '1':
            return novos_chamados()
        elif opcao == '2':
            return buscar_chamado()
        elif opcao == '3':
            return status_finalizado()
        elif opcao == '4':
            return qual_prioridade()
        elif opcao == '5':
            return exibir_estatisticas()
        elif opcao == '6':
            return qual_limpeza()
        else:
            print("Opção inválida, por favor, tente novamente.")

def qual_prioridade():
    while True:
        opcao = input(
'''
GERENCIAR PRIORIDADE
1. Verificar novos pedidos (prioridade 0)
2. Mudar prioridades
3. Ordenar por prioridades
'''
        )
        if opcao == '1':
            return prioridade_zero()
        elif opcao == '2':
            return mudar_prioridade()
        elif opcao == '3':
            return ordenar_prioridade()
        else:
            print("Opção inválida, por favor, tente novamente.")

def qual_limpeza():
    while True:
        opcao = input(
'''
GERENCIAR LIMPEZA
1. Limpar finalizados
2. Reverter ordem dos chamados
3. Limpar lista de chamados
'''
        )
        if opcao == '1':
            return finalizados()
        elif opcao == '2':
            return reverter_lista()
        elif opcao == '3':
            return limpar_lista()
        else:
            print("Opção inválida, por favor, tente novamente.")
