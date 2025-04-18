from collections import deque

class Fila:
    def __init__(self):
        self.itens = deque()

    def esta_vazia(self):
        return len(self.itens) == 0
    
    def enfileirar(self, item):
        self.itens.append(item)

    def desenfileirar(self):
        if not self.esta_vazia():
            return self.itens.popleft()
        else:
            return None
        
    def tamanho(self):
        return len(self.itens)
    
    def frente(self):
        if not self.esta_vazia():
            return self.itens[0]
    
fila = Fila()
print(fila.esta_vazia())