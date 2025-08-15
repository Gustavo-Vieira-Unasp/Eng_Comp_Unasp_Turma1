from libs.register import *
from libs.search import *

finalizado = []

def finalizados():
    concluido = ["n", "não", "nao"]
    for chamado in chamados[:]:
        if any(c in chamado["Resolvido"].lower() for c in concluido):
            pass
        else:
            chamados.remove(chamado)
            finalizado.append(chamado)

def status_finalizado():
    chamado = buscar_chamado()
    if chamado:
        if chamado["Resolvido"].lower() in ["n", "não", "nao"]:
            chamado["Resolvido"] = "Sim"
            print("Status do chamado como 'Resolvido'")
        else: 
            print("Chamado já está finalizado")
    else: 
        print("Chamado não encontrado")