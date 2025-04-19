import array

arr = array.array("d", [0] * 5)
print(arr)

for i in range(5):
    arr[i] = float(input(f"digite o {i+1}º número"))

print(arr)