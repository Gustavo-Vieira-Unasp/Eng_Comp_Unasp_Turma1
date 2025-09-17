interface Cliente():
    def __init__(self, id:int, nome:str):
        self.id = id
        self.nome = nome
        self.proximo = None

    def __str__(self):
        return str(self.id)
    
    def exibir(self):
        print(self.id)
    
    def temProximo(self):
        return self.proximo != None