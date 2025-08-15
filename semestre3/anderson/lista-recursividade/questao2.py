def somar_lista(lista):
    if not lista:
        return 0
    elif len(lista) == 1:
        return lista[0]
    else:
        return lista[0] + somar_lista(lista[1:])
