class Pilha:
    def __init__(self):
        self.itens = []

    def push(self, item):
        self.itens.append(item)
    
    def pop(self):
        return self.itens[-1]
    
    def is_empty(self):
        return len(self.itens) == 0
    
    def __str__(self):
        return f"Pilha: {self.itens}"
    
    