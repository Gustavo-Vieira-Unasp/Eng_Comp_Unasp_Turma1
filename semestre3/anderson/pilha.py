class Pilha:
    def __init__(self):
        self.itens = []

    def push(self, item):
        self.itens.append(item)
    
    def pop(self):
        if not self.is_empty():
            return self.itens.pop()
        else:
            return None
    
    def is_empty(self):
        return len(self.itens) == 0
    
    def __str__(self):
        return f"Pilha: {self.itens}"
    
    def tamanho(self):
        return len(self.itens)
    
    def topo(self):
        if not self.is_empty:
            return self.itens[-1]
        else:
            return None
    
pilha = Pilha()

pilha.push('copo')

pilha.is_empty()