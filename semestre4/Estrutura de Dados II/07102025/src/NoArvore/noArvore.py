class NoArvore:
    def __init__(self, valor : int):
        self.valor: int = valor
        self.esquerdo: NoArvore = None
        self.direito: NoArvore = None

    def __str__(self):
        return str(self.valor)