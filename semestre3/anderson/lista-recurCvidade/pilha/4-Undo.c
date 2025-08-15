#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_STACK_SIZE 100 // Tamanho máximo para a pilha genérica
#define MAX_ACOES 10       // Número máximo de ações que podem ser desfeitas (usando a pilha)

// Sua definição de Pilha
typedef struct {
    int itens[MAX_STACK_SIZE];
    int topo;
} Pilha;

void inicializarPilha(Pilha *p) {
    p->topo = -1;
}

int estaVazia(Pilha *p) {
    return (p->topo == -1);
}

int estaCheia(Pilha *p) {
    return (p->topo == MAX_STACK_SIZE - 1);
}

void push(Pilha *p, int valor) {
    if (estaCheia(p)) {
        printf("Erro: Pilha cheia! Nao eh possivel adicionar mais elementos.\n");
        return;
    }
    p->topo++;
    p->itens[p->topo] = valor;
}

int pop(Pilha *p) {
    if (estaVazia(p)) {
        printf("Erro: Pilha vazia! Nao ha elementos para remover.\n");
        return -1; // Retorna um valor sentinela para indicar erro
    }
    int valor = p->itens[p->topo];
    p->topo--;
    return valor;
}

int peek(Pilha *p) {
    if (estaVazia(p)) {
        printf("Erro: Pilha vazia! Nao ha elementos para ver.\n");
        return -1;
    }
    return p->itens[p->topo];
}

// Variável global para simular o "conteúdo" do editor
char conteudoEditor[200] = "Texto inicial. ";

// Pilha para armazenar os CÓDIGOS das acoes que podem ser desfeitas
Pilha pilhaDesfazer; // Usamos a sua Pilha de int

// Funções para simular diferentes tipos de ações
#define ACAO_DIGITAR_CARACTERE 1
#define ACAO_DELETAR_CARACTERE 2
#define ACAO_FORMATAR_TEXTO    3

// Função para adicionar uma ação e registrá-la para desfazer
void executarAcao(int codigoAcao, const char *descricaoAcao, const char *alteracaoConteudo) {
    // Simula a execução da ação no editor
    strcat(conteudoEditor, alteracaoConteudo);
    printf("\n--- Executando Acao ---\n");
    printf("Acao: %s (Codigo: %d)\n", descricaoAcao, codigoAcao);
    printf("Conteudo atual do editor: \"%s\"\n", conteudoEditor);

    // Registra o CÓDIGO da ação na pilha de desfazer
    // Note que MAX_ACOES é um limite lógico. MAX_STACK_SIZE é o limite físico da Pilha.
    if (pilhaDesfazer.topo + 1 < MAX_ACOES) { // Verifica se ainda há espaço lógico
        push(&pilhaDesfazer, codigoAcao);
    } else {
        printf("Limite de acoes para desfazer atingido (%d acoes). A acao '%s' nao foi registrada para desfazer.\n", MAX_ACOES, descricaoAcao);
    }
}

// Função para desfazer a última acao
void desfazerUltimaAcao() {
    int codigoAcaoDesfeita = pop(&pilhaDesfazer);

    if (codigoAcaoDesfeita != -1) { // -1 é o sentinela para pilha vazia ou erro
        printf("\n--- Desfazendo Acao ---\n");
        printf("Desfazendo acao com codigo: %d\n", codigoAcaoDesfeita);

        // A lógica de reversão real estaria aqui, baseada no código da ação.
        switch (codigoAcaoDesfeita) {
            case ACAO_DIGITAR_CARACTERE:
                printf("  -> Acao de 'Digitar Caractere' desfeita (simulado).\n");
                // Em um editor real, você removeria o último caractere digitado do 'conteudoEditor'.
                // Isso exigiria mais detalhes sobre a ação original.
                break;
            case ACAO_DELETAR_CARACTERE:
                printf("  -> Acao de 'Deletar Caractere' desfeita (simulado).\n");
                // Em um editor real, você reinseriria o caractere deletado.
                break;
            case ACAO_FORMATAR_TEXTO:
                printf("  -> Acao de 'Formatar Texto' desfeita (simulado).\n");
                // Em um editor real, você reverteria a formatação.
                break;
            default:
                printf("  -> Acao desconhecida desfeita.\n");
                break;
        }
        printf("Conteudo do editor apos desfazer (simulado, nao reverte o texto real): \"...estado anterior...\"\n");
    }
}

int main(void) {
    inicializarPilha(&pilhaDesfazer); // Inicializa a pilha de ações

    printf("Iniciando editor com texto: \"%s\"\n", conteudoEditor);

    executarAcao(ACAO_DIGITAR_CARACTERE, "Digitou 'A'", "A");
    executarAcao(ACAO_DIGITAR_CARACTERE, "Digitou 'B'", "B");
    executarAcao(ACAO_DELETAR_CARACTERE, "Deletou ultimo caractere", "(DEL)");
    executarAcao(ACAO_FORMATAR_TEXTO, "Aplicou negrito", " (NEG) ");
    executarAcao(ACAO_DIGITAR_CARACTERE, "Digitou 'C'", "C");

    printf("\n--- Testando Desfazer ---\n");
    desfazerUltimaAcao(); // Desfaz "Digitou 'C'"
    desfazerUltimaAcao(); // Desfaz "Aplicou negrito"
    desfazerUltimaAcao(); // Desfaz "Deletou ultimo caractere"
    desfazerUltimaAcao(); // Desfaz "Digitou 'B'"
    desfazerUltimaAcao(); // Desfaz "Digitou 'A'"
    desfazerUltimaAcao(); // Tenta desfazer mais, pilha vazia

    printf("\n--- Testando Limite de Acoes ---\n");
    inicializarPilha(&pilhaDesfazer); // Reseta a pilha para este teste
    strcpy(conteudoEditor, "Resetado. "); // Reseta o conteúdo do editor

    for (int i = 0; i < MAX_ACOES + 2; i++) {
        char descricao[50];
        sprintf(descricao, "Acao de teste %d", i + 1);
        // Empilhamos um código de ação genérico (e alteramos o conteúdo do editor)
        executarAcao(ACAO_DIGITAR_CARACTERE, descricao, "X");
    }
    printf("\n--- Desfazendo todas as acoes do limite ---\n");
    for (int i = 0; i < MAX_ACOES + 2; i++) {
        desfazerUltimaAcao();
    }

    return 0;
}