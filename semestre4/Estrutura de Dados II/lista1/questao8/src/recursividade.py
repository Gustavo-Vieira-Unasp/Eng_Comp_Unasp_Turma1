def inverterstring(string):
    if len(string) == 0:
        return string
    else:
        return inverterstring(string[1:]) + string[0]

minha_string = "teste bacanudo"
string_invertida = inverterstring(minha_string)
print(f"String original: '{minha_string}'")
print(f"String invertida: '{string_invertida}'")