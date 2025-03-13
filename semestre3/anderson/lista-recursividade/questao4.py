def poupanca(dolares_na_conta = 0, mes = 0):
    cotacao_dolar = [5.30, 5.25, 5.35, 5.40, 5.45, 5.50, 5.45, 5.40, 5.35, 5.30, 5.25, 5.20]
    rendimento = 0.0005
    investimento_reais = 500
    meta100k = 100000
    meta1m = 1000000
    
    cotacao_atual = cotacao_dolar[mes % 12]
    investimento_dolares = investimento_reais/cotacao_atual
    dolares_na_conta *= (1+rendimento)

    dolares_na_conta += investimento_dolares
    mes += 1

    reais_na_conta = dolares_na_conta * cotacao_atual

    if reais_na_conta >= meta100k:
        print(f"Meta de R$ {meta100k} atingida em {mes} meses")
        return mes, mes * investimento_reais, reais_na_conta
    
    if reais_na_conta >= meta1m:
        print(f"Meta de R$ {meta1m} atingida em {mes} meses")
        return mes, mes * investimento_reais, reais_na_conta
    
    return poupanca(dolares_na_conta, mes) 


meses, valor_investido_brl, saldo_final_brl = poupanca()
print(f"- Meses: {meses}")
print(f"- Valor investido (BRL): R$ {valor_investido_brl:.2f}")
print(f"- Saldo final (BRL): R$ {saldo_final_brl:.2f}")