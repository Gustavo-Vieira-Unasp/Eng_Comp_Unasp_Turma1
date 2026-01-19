from Modelos.CalculadoraRPN import CalculadoraRPN
from src.Pilha.Pilha import Pilha
from src.No.No import No

calculadora = CalculadoraRPN()

print(f"Expressão RPN '3 4 +': {calculadora.calcular('3 4 +')}")

print(f"Expressão RPN '5 1 - 2 3 + *': {calculadora.calcular('5 1 - 2 3 + *')}")

print(f"Expressão RPN '10 2 / 8 +': {calculadora.calcular('10 2 / 8 +')}")

try:
    print(f"Expressão RPN '10 0 /': {calculadora.calcular('10 0 /')}")
except ZeroDivisionError as e:
    print(e)