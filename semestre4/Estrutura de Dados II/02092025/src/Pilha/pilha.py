from src.No.no import No

class Pilha():
    def __init__(self, no:No):
        self.base = no
        self.tamanho = 1

    def inserir(self, no:No):
        self.base.proximo = no
        self.tamanho += 1

    def obterProximo(self, no:No):
        if no.proximo == None:
            return no.valor
        else:
            print(self.obterProximo(no.proximo))
            print(no.valor)
            

    def listar(self):
        print(self.obterProximo(self.base))

    def exibirTopo(self, base:No):
        if base.proximo == None:
            return base.valor
        else:
            self.exibirTopo(base.proximo)