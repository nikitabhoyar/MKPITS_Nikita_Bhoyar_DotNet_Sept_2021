//Nested Structure //

#include<stdio.h>

struct complex
{
    int imag;
    float real;
} comp;

struct number
{   
    struct complex comp;
    int integer;
} num1;

int main()
{
    num1.comp.imag = 11;
    num1.comp.real = 5.25;
    num1.integer = 6;


    printf("Imaginary part:%d\n",num1.comp.imag);
    printf("Real part:%d\n",num1.comp.real);
    printf("Integer:%d\n",num1.integer);

return 0;

} 
