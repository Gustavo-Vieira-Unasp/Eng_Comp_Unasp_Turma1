chamados = []

def novos_chamados():
    nome = input("Digite o nome: ")
    motivo = motivos()
    id_gerado = gerar_id()
    descricao = input("Digite a descrição: ")
    
    chamado = {
        "Nome": nome,
        "Motivo": motivo,
        "Descrição": descricao,
        "Prioridade": 0,
        "Resolvido": "Não",
        "ID": id_gerado
    }
    
    chamados.append(chamado)
    return motivo, nome, descricao

def motivos():
    while True:
        opcao = int(input(
            '''
            1. Problemas de conexão
            2. Aparelhos lentos ou sem funcionar
            3. Sistema fora do ar
            4. Recuperar senha
            5. Vírus ou Malware
            6. Problema não identificado
            '''))
        if opcao == 1:
            return "Problemas de Conexão" 
        elif opcao == 2:
            return "Aparelhos Lentos ou sem funcionar" 
        elif opcao == 3:
            return "Sistema fora do ar" 
        elif opcao == 4:
            return "Recuperar senha" 
        elif opcao == 5:
            return "Vírus ou Malware" 
        else:
            return "Problema não identificado" 

def gerar_id():
    id_gerado = len(chamados) + 1
    return id_gerado
