from libs.register import *

finalizado = []

def finalizados():
    concluido = ["n", "não", "nao"]
    for chamado in chamados[:]:
        if any(c in chamado["Resolvido"].lower() for c in concluido):
            pass
        else:
            chamados.remove(chamado)
            finalizado.append(chamado)
            