import heapq

class FilaPrioridade:
    def __init__(self):
        self.fila = []
        self.indice = 0

    def inserir(self, item, prioridade):
        heapq.heappush(self.fila, {prioridade, self.indice, item})
        self.indice += 1

    def remover(self):
        if self.fila:
            return heapq.heappop(self.fila)
        return None
    
fila = FilaPrioridade()
fila.inserir("Paciente dor garganta", 3)
fila.inserir("Paciente dor peito", 2)
fila.inserir("Paciente dificuldade de respirar", 1)

print(fila.fila)
print(fila.remover())
