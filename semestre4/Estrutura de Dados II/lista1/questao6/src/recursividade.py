def torres_de_hanoi(n, origem, destino, auxiliar):
    if n == 1:
        print(f"Mova o disco 1 de {origem} para {destino}")
        return
        
    torres_de_hanoi(n - 1, origem, auxiliar, destino)
    
    print(f"Mova o disco {n} de {origem} para {destino}")
    
    torres_de_hanoi(n - 1, auxiliar, destino, origem)

n_discos = 5
torres_de_hanoi(n_discos, 'Torre A (Origem)', 'Torre C (Destino)', 'Torre B (Auxiliar)')

print(f"\n---")
print(f"A solução para {n_discos} discos requer 2^{n_discos} - 1 = {2**n_discos - 1} movimentos.")