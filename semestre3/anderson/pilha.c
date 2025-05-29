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

int main(void)
{
    int num = 34;
    int resultado = fatorial(num);
    printf("O fatorial de %d é %d", num, resultado);
    return 0;
}
