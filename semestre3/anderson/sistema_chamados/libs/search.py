from libs.register import *

def buscar_chamado():
    criterio = input("Buscar por (1) Nome, (2) ID ou (3) Descrição? ")
    if criterio == "1":
        nome = input("Digite o nome: ")
        for chamado in chamados:
            if chamado["Nome"].lower() == nome.lower():
                print(chamado)
                return chamado
        print("Nenhum chamado encontrado para o nome fornecido.")
    elif criterio == "2":
        id_gerado = int(input("Digite o ID: "))
        for chamado in chamados:
            if chamado["ID"] == id_gerado:
                print(chamado)
                return chamado
        print("Nenhum chamado encontrado para o ID fornecido.")
    elif criterio == "3":
        descricao = input("Digite a descrição: ")
        for chamado in chamados:
            if descricao.lower() in chamado["Decrição"].lower():
                print(chamado)
                return(chamado)
            print("Nenhum chamado encontrado para essa descrição fornecida")
    else:
        print("Critério de busca inválido. Tente novamente.")