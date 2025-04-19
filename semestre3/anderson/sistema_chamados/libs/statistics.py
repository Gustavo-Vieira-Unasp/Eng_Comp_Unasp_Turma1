from collections import Counter
from libs.finished import *
from libs.priority import *
from libs.register import *
from libs.search import *

def exibir_estatisticas():
    total_chamados = len(chamados)
    finalizado = sum(1 for chamado in chamados if chamado["Resolvido"].lower() in ["sim", "s"])
    nao_finalizado = total_chamados - finalizado

    print(f"Total de chamados: {total_chamados}")
    print(f"Total de chamados finalizados: {finalizado}")
    print(f"Total de chamados não finalizados: {nao_finalizado}")

    print("\nPrioridades dos chamados finalizados:")
    prioridades_finalizados = Counter(chamado["Prioridade"] for chamado in chamados if chamado["Resolvido"].lower() in ["sim", "s"])
    for prioridade, quantidade in prioridades_finalizados.items():
        percentual = (quantidade / finalizados * 100) if finalizados else 0
        print(f"Prioridade {prioridade}: {quantidade} chamado(s) ({percentual:.2f}%)")

    print("\nPrioridades dos chamados não finalizados:")
    prioridades_nao_finalizados = Counter(chamado["Prioridade"] for chamado in chamados if chamado["Resolvido"].lower() not in ["sim", "s"])
    for prioridade, quantidade in prioridades_nao_finalizados.items():
        percentual = (quantidade / nao_finalizado * 100) if nao_finalizado else 0
        print(f"Prioridade {prioridade}: {quantidade} chamado(s) ({percentual:.2f}%)")