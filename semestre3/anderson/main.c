#include <stdio.h>

int fatorial(int num){
    if(num == 1){
        return 1;
    }
    
    return num * (fatorial(num - 1));
}

int main()
{
    int num = 6;
    int resultado = fatorial(num);
    printf("O fatorial de %d é %d", num, resultado);
    return 0;
}
