class Aluno():
    def __init__(self, ra:int, name:str, notas:list[float] = []) -> None:
        self.ra = ra
        self.name = name
        self.notas = notas
        self.proximo = None
        self.media : float = round(sum(self.notas)/len(self.notas), 2) if len(self.notas) > 0 else None
    
    def __str__(self):
        return(f'''
ALUNO:
-RA: {self.ra}
-Nome: {self.name}
-Notas: {self.notas}
-Media: {self.media}
               ''')


    def imprimir(self):
        print(self.__str__())

    def temProximo(self):
        return self.proximo != None