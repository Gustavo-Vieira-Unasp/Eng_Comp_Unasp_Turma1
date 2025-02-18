from libs.search import *

def mudar_prioridade():
    chamado = buscar_chamado()
    if chamado:
        nova_prioridade = int(input("Digite a nova prioridade: "))
        chamado["Prioridade"] = nova_prioridade
        print("Prioridade alterada com sucesso.")
    else:
        print("Chamado não encontrado. Não foi possível alterar a prioridade.")

def ordenar_prioridade():
    chamados.sort(key=lambda x: (x["Prioridade"] == 0, x["Prioridade"]))

def prioridade_zero():
    for chamado in chamados:
        if chamado["Prioridade"] == 0:
            print("Há chamados com prioridade 0")
            return True
    print("Não há chamados com prioridade 0")
    return False