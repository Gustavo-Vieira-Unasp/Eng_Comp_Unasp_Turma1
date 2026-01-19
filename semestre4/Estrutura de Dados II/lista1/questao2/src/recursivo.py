def insiraPalavraAqui():
    palavra = input("Insira palavra que quer reverter aqui: ")
    return print(reverte_palavra(palavra))

def reverte_palavra(palavra):
    if len(palavra) == 0:
        return palavra
    else: 
        return reverte_palavra(palavra[1:])+palavra[0]