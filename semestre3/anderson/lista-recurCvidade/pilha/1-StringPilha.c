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

// Função para inverter uma string usando uma pilha
void inverterPilha(char *str) {
    Pilha p;
    inicializarPilha(&p);

    int i = 0;
    //Empilha todos os caracteres da string
    while (str[i] != '\0') {
        if (!estaCheia(&p)) {
            push(&p, str[i]);
        } else {
            printf("Erro: String muito longa para a pilha (MAX = %d)!\n", MAX);
            return;
        }
        i++;
    }

    i = 0;
    //Desempilha os caracteres e os coloca de volta na string
    while (!estaVazia(&p)) {
        str[i] = pop(&p);
        i++;
    }
}

int main(void) {
    char textinho[MAX] = "top 10 recurções";

    printf("String original: %s\n", textinho);
    inverterPilha(textinho);
    printf("String invertida: %s\n", textinho);

    return 0;
}