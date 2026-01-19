from src.Modelos.Aluno import Aluno
from src.Pilha.Pilha import Pilha
from src.Fila.Fila import Fila
from src.No.No import No


#aluno1 = Aluno(123, "Gabriel Chaves", [8.9, 7.2, 10])
#aluno2 = Aluno(456, "Marilha Mendonça", [0.7, 0.8, 0.3])
#aluno3 = Aluno(444, "Genifer Gasparin", [9, 10.5, 7])
#aluno4 = Aluno(199, "Matabares Morilles", [8, 8, 8])

#pilha = Fila()
#pilha.inserir(aluno1)
#pilha.inserir(aluno2)
#pilha.inserir(aluno3)
#pilha.inserir(aluno4)

#pilha.listar()

fila = Fila()

fila.inserir(No("Dudarts"))
fila.inserir(No("Lucas Eduardo"))
fila.inserir(No("Pedro Eduardo"))

fila.listar()
removido = fila.remover()
print(f"Removido: {removido}")
