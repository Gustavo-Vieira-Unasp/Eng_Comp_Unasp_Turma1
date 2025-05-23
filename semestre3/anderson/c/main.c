//#include <stdio.h>
int main (void) {
    printf("Hello Word!");
    return 0;
} 

int fatorial (int num){
    if (num == 1){
        return 1;
    }
    else{
        return num * fotiral(num - 1);
    }
    
}

int main (void){

    int num = 9;
    int resultado = fatorial(num);
    printf("O fatroial de %d é %d", num, resultado);
    return 0;
    
    /**------------------------------------------------------------------------------------------------------------------------------------**/

//#include <stdlib.h>




