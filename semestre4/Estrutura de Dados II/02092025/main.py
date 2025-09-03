from src.No.no import No
from src.Pilha.pilha import Pilha

no = No("Dudarts")
pilha = Pilha(no)

no2 = No("Lucas Eduardo")
pilha.inserir(no2)

no3 = No("Pedro Eduardo")
pilha.inserir(no3)

pilha.listar()