import os
import sys

sys.stdout.reconfigure(encoding='utf-8')

def k_complexo(diretorio, nivel):
    a = os.scandir(diretorio)
    for item in a:
        if item.is_file():
            exibir(item.name, nivel, "📁" if item.is_dir() else "📄")
        elif item.is_dir():
            exibir(item.name, nivel, "📁" if item.is_dir() else "📄")
            k(f"{diretorio}\{item.name}", nivel + 1)
        else:
            print("eh qualquer outro arquivo")

def k(diretorio, nivel):
    a = os.scandir(diretorio)
    for item in a:
        exibir(item.name, nivel, "📁" if item.is_dir() else "📄")
        if item.is_dir():
            k(os.path.join(diretorio, item.name), nivel + 1)

def exibir(nome, nivel, icone):
    print(f"{" "*(4*nivel)}{icone} {nome}")