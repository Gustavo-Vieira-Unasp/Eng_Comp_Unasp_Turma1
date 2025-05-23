// #include <stdlib.h>
// #include <stdio.h>
#define MAX 100

typedef struct
{
	int itens [MAX];
    int topo;
} Pilha;


void inicializarPilha(Pilha *p)
{
	p -> topo = -1;
}


int estaVazia(Pilha *p)
{
	return (p -> topo == -1);
}


int estaCheia(Pilha * p)
{
	return (p -> topo == MAX - 1);
}

void push(Pilha *p, int valor){
	if (estaCheia(p)){
    	printf("Minha pilha ta cheia");
        return;
    }
    p -> topo++;
    p -> itens[p->topo] = valor;
}

int pop(Pilha *p){
	if(estaVazia(p)){
    	printf("erro: pilha vazia\n");
        return;
    }
    int valor = p -> itens[p-> topo];
    p->topo--;
}

int peek(Pilha *p){
	if (estaVazia(p)){
    	printf("Erro: Pilha esta vazia\n");
        return;
    }
    
    return p-> itens[p->topo];
}
