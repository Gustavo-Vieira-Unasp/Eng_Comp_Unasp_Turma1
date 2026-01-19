from src.No.no import No
from src.Pilha.pilha import Pilha

pilha = Pilha()

pilha.inserir(No("Dudarts"))
pilha.inserir(No("Lucas Eduardo"))
pilha.inserir(No("Pedro Eduardo"))

pilha.listar()
removido = pilha.remover()
print(f"Removido: {removido}")
