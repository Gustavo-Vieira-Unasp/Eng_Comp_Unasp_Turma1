#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

#define MAX_SIZE 100

typedef struct
{
    char itens[MAX_SIZE];
    int topo;
} PilhaChar;

void inicializarPilhaChar(PilhaChar *p)
{
    p->topo = -1;
}

int estaVaziaPilhaChar(PilhaChar *p)
{
    return (p->topo == -1);
}

int estaCheiaPilhaChar(PilhaChar *p)
{
    return (p->topo == MAX_SIZE - 1);
}

void pushChar(PilhaChar *p, char caractere)
{
    if (estaCheiaPilhaChar(p))
    {
        // Neste contexto, apenas evitamos o push para não sobrescrever
        // Mas o erro será tratado na função verifica_palindromo
        return;
    }
    p->topo++;
    p->itens[p->topo] = caractere;
}

char popChar(PilhaChar *p)
{
    if (estaVaziaPilhaChar(p))
    {
        return '\0'; // Retorna caractere nulo para indicar erro/vazio
    }
    char caractere = p->itens[p->topo];
    p->topo--;
    return caractere;
}

// --- Definição e Funções da Fila (para caracteres) ---
typedef struct
{
    char itens[MAX_SIZE];
    int frente;
    int tras;
    int contador;
} FilaChar;

void inicializarFilaChar(FilaChar *f)
{
    f->frente = 0;
    f->tras = -1;
    f->contador = 0;
}

int estaVaziaFilaChar(FilaChar *f)
{
    return (f->contador == 0);
}

int estaCheiaFilaChar(FilaChar *f)
{
    return (f->contador == MAX_SIZE);
}

void enqueueChar(FilaChar *f, char caractere)
{
    if (estaCheiaFilaChar(f))
    {
        // Neste contexto, apenas evitamos o enqueue
        // Mas o erro será tratado na função verifica_palindromo
        return;
    }
    f->tras = (f->tras + 1) % MAX_SIZE;
    f->itens[f->tras] = caractere;
    f->contador++;
}

char dequeueChar(FilaChar *f)
{
    if (estaVaziaFilaChar(f))
    {
        return '\0'; // Retorna caractere nulo para indicar erro/vazio
    }
    char caractere = f->itens[f->frente];
    f->frente = (f->frente + 1) % MAX_SIZE;
    f->contador--;
    return caractere;
}

//Vai verificar se é palindromo atravez de fila e pilha
int verifica_palindromo(const char *palavra)
{
    PilhaChar pilha;
    FilaChar fila;

    inicializarPilhaChar(&pilha);
    inicializarFilaChar(&fila);

    int i = 0;
    // Coloca cada caractere da palavra (em minúsculo) na pilha e na fila.
    while (palavra[i] != '\0')
    {
        char caractere_min = tolower(palavra[i]); // Converte para minúsculo para a comparação

        // Verifica o limite de tamanho antes de adicionar
        if (estaCheiaPilhaChar(&pilha) || estaCheiaFilaChar(&fila)) {
            printf("Erro: Palavra '%s' muito longa para as estruturas de dados. Maximo: %d caracteres.\n", palavra, MAX_SIZE);
            return 0; // Não pode verificar palíndromo se exceder o limite
        }

        pushChar(&pilha, caractere_min);
        enqueueChar(&fila, caractere_min);
        i++;
    }

    // Compara os caracteres desempilhados e desenfileirados
    while (!estaVaziaPilhaChar(&pilha)) // Loop enquanto a pilha e a fila tiverem elementos
    {
        char char_pilha = popChar(&pilha);
        char char_fila = dequeueChar(&fila);

        // Se houver qualquer divergência, não é um palíndromo.
        if (char_pilha != char_fila)
        {
            return 0; // Não é palíndromo
        }
    }

    return 1; // Se todos os caracteres coincidiram, é um palíndromo
}

int main(void)
{
    printf("--- Verificacao de Palindromo com Pilha e Fila ---\n\n");

    const char *palavras[] = {
        "arara",
        "ovo",
        "Madame",
        "A base do teto desaba",
        "Socoram me subi no onibus em Marrocos"
    };

    int num_palavras = sizeof(palavras) / sizeof(palavras[0]);

    for (int i = 0; i < num_palavras; i++)
    {
        printf("Palavra: \"%s\" -> Eh palindromo? %s\n",
               palavras[i],
               verifica_palindromo(palavras[i]) ? "Sim" : "Nao");
    }

    return 0;
}