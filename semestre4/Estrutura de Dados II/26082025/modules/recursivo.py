import os

def k(diretorio, nivel):
    a = os.scandir(diretorio)
    for item in a:
        if item.is_file():
            exibir(item.name, nivel)
        elif item.is_dir():
            exibir(item.name, nivel)
            k(f"{diretorio}\{item.name}", nivel + 1)
        else:
            print("eh qualquer outro arquivo")

def k_simples(diretorio, nivel):
    a = os.scandir(diretorio)
    for item in a:
        exibir(item.name, nivel)
        if item.is_dir():
            k(f"{diretorio}/{item.name}", nivel + 1)

def exibir(nome, nivel):
    print(f"{" "*(4*nivel)} |- {nome}")
    return