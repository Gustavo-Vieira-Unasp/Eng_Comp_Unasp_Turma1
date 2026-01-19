from src.No.No import No

class ListaEncadeada:
    def __init__(self):
        self.inicio:No = 0
        # self.fim:No = 0
        self.tamanho:int = 0

    def taVazia(self) -> bool:
        return self.tamanho == 0
    
    def inserir(self, no:No):
        atual = self.inicio
        if self.taVazia():
            self.inicio = no
        else: 
            self.obterUltimo().proximo = no
        tamanho += 1
            
    def obterUltimo(self):
        atual = self.inicio
        while atual.proximo != None:
            atual = atual.proximo
        return atual

    def inserir(self, indice:int, no:No) -> None:
        pass

    def remover(self, valor) -> No | None:
        achou = self.buscar(self.inicio, valor)
        if achou:
            excluido = achou.proximo
            achou.proximo = achou.proximo.proximo
            self.tamanho -= 1
            return excluido
        return None
        
    def buscar(self, no:No, valor):
        if no.valor.nome == valor:
            return no
        elif no.temProximo() and no.proximo.valor.nome == valor:
            return no.proximo
        elif not no.temProximo():
            return None
        else: 
            self._rem(no.proximo, valor)

    def removerTodos(self, valor) -> list[No]:
        removidos = []
        while True:
            removido = self.remover(valor)
            if removido:
                removidos.append(removido)
            else: 
                return removidos

    def removerPorIndice(indice:int) -> No:
        pass

    def listar(self) -> None:
        pass