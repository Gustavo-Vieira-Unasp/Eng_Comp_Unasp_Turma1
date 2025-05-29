#include <stdio.h>
#include <stdlib.rand>
#include <time.h>

#define MAX 100 

typedef struct
{
    int itens[MAX];
    int frente;
    int tras;
    int contador;
} Fila;

void inicializarFila(Fila *f)
{
    f->frente = 0;
    f->tras = -1;
    f->contador = 0;
}

int estaVazia(Fila *f)
{
    return (f->contador == 0);
}

int estaCheia(Fila *f)
{
    return (f->contador == MAX);
}

void enqueue(Fila *f, int valor)
{
    if (estaCheia(f))
    {
        printf("Erro: Fila cheia\n");
        return;
    }
    f->tras = (f->tras + 1) % MAX;
    f->itens[f->tras] = valor;
    f->contador++;
}

int dequeue(Fila *f)
{
    if (estaVazia(f))
    {
        printf("Erro: Fila vazia\n");
        return -1;
    }
    int valor = f->itens[f->frente];
    f->frente = (f->frente + 1) % MAX;
    f->contador--;
    return valor;
}

int front(Fila *f)
{
    if (estaVazia(f))
    {
        printf("Erro: Fila vazia\n");
        return -1;
    }
    return f->itens[f->frente];
}

int main(void)
{
    Fila filaDeClientes;
    inicializarFila(&filaDeClientes);

    srand(time(NULL)); // Inicializa o gerador de números aleatórios para IDs de cliente
    int id_cliente = 100; // ID inicial para os clientes, incrementado a cada nova chegada

    printf("--- Simulacao de Fila de Atendimento Bancario ---\n\n");

    // Simula a chegada de alguns clientes na fila
    printf("--- Chegada de Clientes ---\n");
    for (int i = 0; i < 7; i++)
    {
        // Adiciona um cliente à fila e mostra uma mensagem de chegada
        enqueue(&filaDeClientes, id_cliente++);
        printf("Cliente %d chegou e entrou na fila.\n", id_cliente - 1);
    }
    printf("\n");

    // Simula o atendimento de alguns clientes que já estão na fila
    printf("--- Atendimento de Clientes ---\n");
    for (int i = 0; i < 3; i++)
    {
        if (!estaVazia(&filaDeClientes))
        {
            int clienteAtendido = dequeue(&filaDeClientes);
            printf("Cliente %d foi atendido e saiu da fila.\n", clienteAtendido);
        }
    }
    printf("\n");

    // Simula mais chegadas e atendimentos intercalados
    printf("--- Mais Chegadas e Atendimentos Intercalados ---\n");
    enqueue(&filaDeClientes, id_cliente++);
    printf("Cliente %d chegou e entrou na fila.\n", id_cliente - 1);

    if (!estaVazia(&filaDeClientes))
    {
        int clienteAtendido = dequeue(&filaDeClientes);
        printf("Cliente %d foi atendido e saiu da fila.\n", clienteAtendido);
    }

    enqueue(&filaDeClientes, id_cliente++);
    printf("Cliente %d chegou e entrou na fila.\n", id_cliente - 1);

    enqueue(&filaDeClientes, id_cliente++);
    printf("Cliente %d chegou e entrou na fila.\n", id_cliente - 1);

    if (!estaVazia(&filaDeClientes))
    {
        int clienteAtendido = dequeue(&filaDeClientes);
        printf("Cliente %d foi atendido e saiu da fila.\n", clienteAtendido);
    }
    printf("\n");

    // Atende todos os clientes restantes na fila até que ela esteja vazia
    printf("--- Esvaziando a Fila ---\n");
    while (!estaVazia(&filaDeClientes))
    {
        int clienteAtendido = dequeue(&filaDeClientes);
        printf("Cliente %d foi atendido e saiu da fila.\n", clienteAtendido);
    }
    printf("\n");

    // Verifica se a fila está vazia após o esvaziamento completo
    printf("Fila esta vazia? %s\n\n", estaVazia(&filaDeClientes) ? "Sim" : "Nao");

    // Testa o comportamento da fila quando ela está cheia
    printf("--- Teste de Fila Cheia ---\n");
    for (int i = 0; i < MAX + 2; i++) // Tenta enfileirar mais clientes do que a capacidade MAX
    {
        enqueue(&filaDeClientes, id_cliente++);
        // Note que o "Erro: Fila cheia" será impresso quando o limite for atingido
    }
    printf("\n");

    // Testa o comportamento ao tentar desenfileirar de uma fila já vazia
    printf("--- Teste de Fila Vazia apos esvaziar ---\n");
    dequeue(&filaDeClientes); // Tenta desenfileirar de uma fila que já está vazia

    return 0;
}