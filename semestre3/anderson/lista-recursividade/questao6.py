#GRUPO NATURA - NTCO3
def acoes(dinheiro = 0, mes = 0):
    valor_acoes = [18.00, 17.34, 18.35, 17.79, 18.59, 16.36, 16.07, 16.53, 13.90, 15.75, 13.62, 14.44]
    valor_dividendos = [0.0130, 0.1192, 0.1819, 0.1819, 0.158, 0.2991, 0.2587, 0.1315, 0.1278, 0.1317, 0.7079, 0.0324]
    valor_dividendo = valor_dividendos[mes % 12]
    valor_provento = sum(valor_dividendos)/len(valor_dividendos)
    investimento = 80
    valor_acao = valor_acoes[mes % 12]
    dy = (valor_provento/valor_acao)*100

    meta100k = 100000
    meta1m = 1000000

    num_acoes = investimento//valor_acao
    lucros_dividendos = num_acoes*valor_dividendo
    dinheiro += lucros_dividendos
    mes += 1

    if dinheiro >= meta100k:
        print(f'Meta de R${meta100k} atingida em {mes} meses, com DY de{dy}')
        return mes, mes*investimento, dinheiro
    
    if dinheiro >= meta1m:
        print(f'Meta de R${meta1m} atingida em {mes} meses, com DY de {dy}')
        return mes, mes*investimento, dinheiro