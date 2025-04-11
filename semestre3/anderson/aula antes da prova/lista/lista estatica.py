import array 

arr = array.array ('f', [0]*5)
print(arr)

for i in range(5):
    arr[i] = float(input(f"digite o {i+1}°:"))
    print(arr)

























#Exemplo de Alocação Estática em Python
# # Criando um array de tamanho fixo (simulando alocação estática)

# n = 5

# arr_estatico = [None] * n  # Lista de tamanho fixo inicializada com zeros

# # Preenchendo o array

# for i in range(n):

#    arr_estatico[i] = i * 2

# print("Array Estático:", arr_estatico)

# #Array Estático: [0, 2, 4, 6, 8]