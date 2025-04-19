investimento = 80
def acoes(dinheiro = 0, mes = 0):
    valor_acoes_natura = [18.00, 17.34, 18.35, 17.79, 18.59, 16.36, 16.07, 16.53, 13.90, 15.75, 13.62, 14.44]
    valor_dividendos_natura = [0.0130, 0.1192, 0.1819, 0.1819, 0.158, 0.2991, 0.2587, 0.1315, 0.1278, 0.1317, 0.7079, 0.0324]
    valor_dividendo_natura = valor_dividendos_natura[mes % 12]
    valor_provento_natura = sum(valor_dividendos_natura)/len(valor_dividendos_natura)
    valor_acao_natura = valor_acoes_natura[mes % 12]
    dy_natura = (valor_provento_natura/valor_acao_natura)*100

    valor_acoes_tauros = [20.00, 19.34, 20.35, 19.79, 15.59, 14.36, 14.07, 12.53, 11.90, 9.75, 7.62, 8.44]
    valor_dividendos_tauros = [0.0139, 0.0192, 0.1119, 0.2819, 0.1158, 0.2091, 0.2507, 0.0915, 0.1281, 0.2217, 0.7079, 0.1324]
    valor_dividendo_tauros = valor_dividendos_tauros[mes % 12]
    valor_provento_tauros = sum(valor_dividendos_tauros)/len(valor_dividendos_tauros)
    valor_acao_tauros = valor_acoes_tauros[mes % 12]
    dy_tauros = (valor_provento_tauros/valor_acao_tauros)*100

    valor_acoes_colgate = [29.00, 29.34, 28.35, 29.79, 25.59, 24.36, 24.07, 22.53, 21.90, 29.75, 27.62, 28.44]
    valor_dividendos_colgate = [0.1139, 0.2192, 0.1219, 0.2519, 0.1858, 0.2091, 0.2507, 0.1915, 0.1981, 0.2217, 0.7179, 0.2324]
    valor_dividendo_colgate = valor_dividendos_colgate[mes % 12]
    valor_provento_colgate = sum(valor_dividendos_colgate)/len(valor_dividendos_colgate)
    valor_acao_colgate = valor_acoes_colgate[mes % 12]
    dy_colgate = (valor_provento_colgate/valor_acao_colgate)*100

    meta100k = 100000
    meta1m = 1000000

    num_acoes_natura = investimento//valor_acao_natura
    lucros_dividendos = num_acoes_natura*valor_dividendo_natura
    dinheiro += lucros_dividendos
    mes += 1

    if dinheiro >= meta100k:
        print(f'Meta de R${meta100k} atingida em {mes} meses, com DY de{dy}')
        return mes, mes*investimento, dinheiro
    
    if dinheiro >= meta1m:
        print(f'Meta de R${meta1m} atingida em {mes} meses, com DY de {dy}')
        return mes, mes*investimento, dinheiro
    
    return acoes(dinheiro,)