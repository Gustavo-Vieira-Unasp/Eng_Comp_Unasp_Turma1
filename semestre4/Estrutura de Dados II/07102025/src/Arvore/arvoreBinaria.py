from src.NoArvore.noArvore import NoArvore as No

class ArvoreBinaria:
    def __init__(self):
        self.root: No = None

    def inserir(self, no:No) -> None:
        if not self.root:
            self.root = no
        else:
            self._inserir(self.root, no)

    def _inserir(self, pai:No, no:No) -> None:
        if not pai.esquerdo:
            pai.esquerdo = no
            return 
        elif not pai.direito:
            pai.direito = no
            return
        else:
            if pai.esquerdo.esquerdo and pai.esquerdo.direito:
                return self._inserir(pai.direito, no)
            else:
                return self._inserir(pai.esquerdo, no)
        
    def exibir(self):
        pass

    def _exibir(self):
        pass