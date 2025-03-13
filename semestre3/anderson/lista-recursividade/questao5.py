def bitcoin(bitcoins_na_conta = 0, mes = 0):
    valor_bitcoin = 664484
    cotacao_bitcoin = [209410, 212335, 306600, 359693, 316517, 355299, 352500, 368540, 333842, 345411, 409131, 580819]
    investimento_reais = 250
    rendimento = 0.0005
    meta100k = 100000
    meta1m = 1000000
    metabitcoin = valor_bitcoin

    cotacao_atual = cotacao_bitcoin[mes % 12]
    investimento_bitcoin = investimento_reais/cotacao_atual
    bitcoins_na_conta *= (1+rendimento)

    bitcoins_na_conta += investimento_bitcoin
    mes += 1
    
    reais_na_conta = bitcoins_na_conta * cotacao_atual

    if reais_na_conta >= meta100k:
        print(f'Meta de R${meta100k} atingida em {mes} meses')
        return mes, mes*investimento_reais, reais_na_conta
    
    if reais_na_conta >= meta1m:
        print(f'Meta de R${meta1m} atingida em {mes} meses')
        return mes, mes*investimento_reais, reais_na_conta
    
    if reais_na_conta >= metabitcoin:
        print(f'Meta de 1 bitcoin atingida em {mes} meses') 

    return bitcoin(bitcoins_na_conta, mes)

meses, valor_investido_brl, saldo_final_brl = bitcoin()
print(f"- Meses: {meses}")
print(f"- Valor investido (BRL): R$ {valor_investido_brl:.2f}")
print(f"- Saldo final (BRL): R$ {saldo_final_brl:.2f}")