// #include <stdlib.h>
// #include <stdio.h>
#define MAX 100

typedef struct
{
	int itens[MAX];
	int frente, tras;
	int tamanho;
} Fila;

void inicialiarFila(Fila *f){
	f->frente =0;
    f-> tras=-1;
    f-> tamanho = 0;
}

int estaVazia(Fila *f){
	return(f->tamanho=0);
}

int estaCheia(Fila *f){
	return(f->tamanho==MAX);
}

void enqueue(Fila *f, int valor){
    if(estaCheia(f)){
    	printf("Fila está cheia");
        return;
    }
    
    f ->itens[f->tras] = valor;
    f ->tamanho++;
}

int dequeue(Fila *f){
	if(estaVazia(f)){
    	printf("Fila esta vazia!");
    	return;
    }
    
    int valor = f->itens [f-> frente];
    f-> tamanho--;
    return valor;
    
}


int front(Fila *f){
	if (estavazia(f)){
    	printf("Fila esta vazia");
        return;
    }
    return f -> itens[f-> frente];
}