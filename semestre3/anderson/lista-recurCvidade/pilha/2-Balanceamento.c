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

//Cria o par
int isPar(char charAbertura, char charFechamento) {
    return (charAbertura == '(' && charFechamento == ')') ||
           (charAbertura == '[' && charFechamento == ']') ||
           (charAbertura == '{' && charFechamento == '}');
}

//Confere se esta balanceado certinho
int balaceamento(const char *expressao) {
    Pilha p;
    inicializarPilha(&p);

    int i = 0;
    while (expressao[i] != '\0') {
        char caractereAtual = expressao[i];

        // Se for um delimitador de abertura, empilha
        if (caractereAtual == '(' || caractereAtual == '[' || caractereAtual == '{') {
            push(&p, caractereAtual);
        }
        // Se for um delimitador de fechamento
        else if (caractereAtual == ')' || caractereAtual == ']' || caractereAtual == '}') {
            // Se a pilha estiver vazia, significa que não há delimitador de abertura correspondente
            if (estaVazia(&p)) {
                return 0; // Não balanceado
            }
            // Desempilha o caractere do topo
            char topoPilha = pop(&p);

            // Verifica se o delimitador desempilhado forma um par com o caractere atual
            if (!isPar(topoPilha, caractereAtual)) {
                return 0; // Não balanceado
            }
        }
        // Ignora outros caracteres (números, operadores, letras)
        i++;
    }

    // Ao final da expressão, a pilha deve estar vazia.
    // Se não estiver, significa que há delimitadores de abertura sem fechamento.
    return estaVazia(&p) ? 1 : 0;
}

int main(void) {
    // Testes
    char exp1[] = "{[()]}";
    char exp2[] = "()]"

    printf("Expressao: \"%s\" -> Balanceada: %s\n", exp1, balaceamento(exp1) ? "Sim" : "Nao");
    printf("Expressao: \"%s\" -> Balanceada: %s\n", exp2, balaceamento(exp2) ? "Sim" : "Nao");

    return 0;
}