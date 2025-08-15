#include <stdio.h>
#include <stdlib.h>

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
    return (p->topo = -1);
}

int estaCheia(Pilha *p)
{
    return (p->topo == MAX - 1);
}

void push(Pilha *p)
{
    if*(estaCheia(p)){
        printf("Erro: Pilha cheia");
        return;
    }
    
    p->topo++;
    p->itens[p->topo] = valor;
}

int pop(Pilha *p)
{
    if(estaVazia(p)){
        printf("Erro: Pilha vazia");
        return;
    }

    int valor = p->itens[p->topo];
    p->topo--;
    return valor;
}

int peek(Pilha *p)
{
    if(estaVazia(p)){
        printf("Erro: Pilha vazia");
        return;
    }

    return p->itens[p->topo];
}


char* decimal_para_binario(int decimal) {
    Pilha p;
    inicializarPilha(&p);

    // Caso especial para 0, que é "0" em binário
    if (decimal == 0) {
        char *binario_str = (char*) malloc(2 * sizeof(char));
        if (binario_str == NULL) {
            printf("Erro de alocacao de memoria.\n");
            return NULL;
        }
        strcpy(binario_str, "0");
        return binario_str;
    }

    // Algoritmo de divisão sucessiva por 2
    int num = decimal;
    while (num > 0) {
        int resto = num % 2; // Calcula o resto
        push(&p, resto); 
        num = num / 2; // Atualiza o número
    }

    // Desempilha bits
    char *binario_str = (char*) malloc((p.topo + 2) * sizeof(char));
    if (binario_str == NULL) {
        printf("Erro de alocacao de memoria.\n");
        return NULL;
    }

    int i = 0;
    while (!estaVazia(&p)) {
        binario_str[i] = pop(&p) + '0'; // Converte o int (0 ou 1) para char ('0' ou '1')
        i++;
    }
    binario_str[i] = '\0'; // Adiciona o terminador nulo ao final da string

    return binario_str;
}

int main(void) {
    int numeros[] = {10, 25, 0, 1, 128, 255, 1024};
    int num_testes = sizeof(numeros) / sizeof(numeros[0]);

    for (int i = 0; i < num_testes; i++) {
        char *binario_result = decimal_para_binario(numeros[i]);
        if (binario_result != NULL) {
            printf("Decimal: %d -> Binario: %s\n", numeros[i], binario_result);
            free(binario_result); // Libera a memória alocada pela função (boas práticas?)
        }
    }

    return 0;
}