#include <stdio.h>
#include <stdlib.h> 
#include <string.h>
#include <ctype.h> 

#define MAX 100 

typedef struct
{
    int itens[MAX];
    int topo;
} Pilha;

void inicializarPilha(Pilha *p)
{
    p->topo = -1;
}

int estaVazia(Pilha *p)
{
    return (p->topo == -1); // Correção: uso de '==' para comparação
}

int estaCheia(Pilha *p)
{
    return (p->topo == MAX - 1);
}

void push(Pilha *p, int valor) // 'valor' é o dado a ser empilhado
{
    if (estaCheia(p))
    {
        printf("Erro: Pilha cheia\n");
        return;
    }
    p->topo++;
    p->itens[p->topo] = valor;
}

int pop(Pilha *p)
{
    if (estaVazia(p))
    {
        printf("Erro: Pilha vazia\n");
        return -1; // Retorno de erro padrão para funções que devolvem int
    }
    int valor = p->itens[p->topo];
    p->topo--;
    return valor;
}

int peek(Pilha *p)
{
    if (estaVazia(p))
    {
        printf("Erro: Pilha vazia\n");
        return -1;
    }
    return p->itens[p->topo];
}

//Avaliacao da opcao matematica
int avaliar_posfixa(const char *expressao)
{
    Pilha p;
    inicializarPilha(&p);

    // strdup cria uma cópia mutável da string, pois strtok a modifica.
    // A memória alocada por strdup deve ser liberada com free() no final.
    char *expressao_copia = strdup(expressao);
    if (expressao_copia == NULL)
    {
        printf("Erro de alocacao de memoria.\n");
        return -1;
    }

    char *token;
    token = strtok(expressao_copia, " "); // Divide a expressão em tokens (números ou operadores)

    while (token != NULL)
    {
        // Verifica se o token é um número. Implementação básica para inteiros (incluindo negativos).
        if (isdigit(token[0]) || (token[0] == '-' && strlen(token) > 1 && isdigit(token[1])))
        {
            push(&p, atoi(token)); // Converte string para inteiro e empilha
        }
        else // É um operador
        {
            // Para realizar uma operação, a pilha deve ter pelo menos dois operandos.
            if (p.topo < 1)
            {
                printf("Erro: Expressao mal formatada (poucos operandos para '%s').\n", token);
                free(expressao_copia);
                return -1;
            }

            int operando2 = pop(&p);
            int operando1 = pop(&p);
            int resultado;

            switch (token[0]) // Assume que operadores são caracteres únicos
            {
                case '+': resultado = operando1 + operando2; break;
                case '-': resultado = operando1 - operando2; break;
                case '*': resultado = operando1 * operando2; break;
                case '/':
                    if (operando2 == 0) // Previne divisão por zero
                    {
                        printf("Erro: Divisao por zero.\n");
                        free(expressao_copia);
                        return -1;
                    }
                    resultado = operando1 / operando2;
                    break;
                default:
                    printf("Erro: Operador desconhecido '%s'.\n", token);
                    free(expressao_copia);
                    return -1;
            }
            push(&p, resultado); // Empilha o resultado da operação
        }
        token = strtok(NULL, " "); // Continua para o próximo token
    }

    //Verificação
    if (estaVazia(&p) || p.topo > 0)
    {
        printf("Erro: Expressao mal formatada (final da expressao).\n");
        free(expressao_copia);
        return -1;
    }

    int resultado_final = pop(&p);
    free(expressao_copia); // Libera a memória alocada por strdup
    return resultado_final;
}

int main(void)
{
    printf("--- Avaliacao de Expressao Pos-fixa ---\n");

    printf("\"2 3 +\" = %d (Esperado: 5)\n", avaliar_posfixa("2 3 +"));
    printf("\"5 10 *\" = %d (Esperado: 50)\n", avaliar_posfixa("5 10 *"));
    printf("\"10 2 /\" = %d (Esperado: 5)\n", avaliar_posfixa("10 2 /"));
    printf("\"15 7 -\" = %d (Esperado: 8)\n", avaliar_posfixa("15 7 -"));
    printf("\"2 3 + 4 *\" = %d (Esperado: 20)\n", avaliar_posfixa("2 3 + 4 *")); // (2+3)*4 = 5*4 = 20
    printf("\"10 2 3 + *\" = %d (Esperado: 50)\n", avaliar_posfixa("10 2 3 + *")); // 10*(2+3) = 10*5 = 50
    printf("\"-5 2 +\" = %d (Esperado: -3)\n", avaliar_posfixa("-5 2 +")); // Teste com número negativo

    printf("\n--- Testes de Erro ---\n");
    printf("\"2 +\" = %d (Esperado: -1 - poucos operandos)\n", avaliar_posfixa("2 +"));
    printf("\"2 3 4 +\" = %d (Esperado: -1 - muitos operandos)\n", avaliar_posfixa("2 3 4 +"));
    printf("\"10 0 /\" = %d (Esperado: -1 - divisao por zero)\n", avaliar_posfixa("10 0 /"));
    printf("\"ABC 3 +\" = %d (Esperado: -1 - operando invalido)\n", avaliar_posfixa("ABC 3 +"));
    printf("\"\" = %d (Esperado: -1 - expressao vazia)\n", avaliar_posfixa(""));
    printf("\"1 2 #\" = %d (Esperado: -1 - operador desconhecido)\n", avaliar_posfixa("1 2 #"));

    return 0;
}