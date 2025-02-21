chamados = []

def novos_chamados():
    nome = input("Digite o nome: ")
    motivo = motivos()
    id_gerado = gerar_id()
    descricao = descricao_valida()
    
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
        try:
            opcao = int(input(
                '''
                1. Problemas de conexão
                2. Aparelhos lentos ou sem funcionar
                3. Sistema fora do ar
                4. Recuperar senha
                5. Vírus ou Malware
                6. Problema não identificado
                '''))
            if opcao in [1, 2, 3, 4, 5, 6]:
                motivos = [
                    "Problemas de Conexão",
                    "Aparelhos Lentos ou sem funcionar",
                    "Sistema fora do ar",
                    "Recuperar senha",
                    "Vírus ou Malware",
                    "Problema não identificado"
                ]
                return motivos[opcao - 1]
            else:
                print("Opção inválida, por favor, tente novamente.")
        except ValueError:
            print("Entrada inválida, por favor, insira um número.")

def descricao_valida():
    while True:
        descricao = input("Digite a descrição: ")
        if len(descricao.strip()) < 10:  # Definindo um mínimo de 10 caracteres para a descrição
            print("A descrição deve ter pelo menos 10 caracteres. Por favor, tente novamente.")
        else:
            return descricao

def gerar_id():
    id_gerado = len(chamados) + 1
    return id_gerado
