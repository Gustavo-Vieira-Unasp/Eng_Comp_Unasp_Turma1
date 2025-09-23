import os
import sys

sys.stdout.reconfigure(encoding='utf-8')

def insiraDiretorioAqui():
    diretorio = input("Coloque aqui o path do diretório que deseja que seja lido:")
    return LeitorDeDiretorios(diretorio, 0)

def LeitorDeDiretorios(diretorio, nivel):
    a = os.scandir(diretorio)
    for item in a:
        exibir(item.name, nivel, "📁" if item.is_dir() else "📄")
        if item.is_dir():
            LeitorDeDiretorios(os.path.join(diretorio, item.name), nivel + 1)

def exibir(nome, nivel, icone):
    print(f"{" "*(4*nivel)}{icone} {nome}")