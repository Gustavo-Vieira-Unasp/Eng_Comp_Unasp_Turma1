def poupanca(investimento):
    if investimento <= 10000000:
        tempo = 0
        if round(investimento) == 10000000:
            return tempo
        else: 
            tempo +=1
            taxa = 1.05
            investimento += 500
