def reverte_palavra(palavra):
    if len(palavra) == 0:
        return palavra
    else: 
        return reverte_palavra(palavra[1:]+palavra[0])
palavra = "diguidiguiboidiguijoigoboi"
print(reverte_palavra(palavra))