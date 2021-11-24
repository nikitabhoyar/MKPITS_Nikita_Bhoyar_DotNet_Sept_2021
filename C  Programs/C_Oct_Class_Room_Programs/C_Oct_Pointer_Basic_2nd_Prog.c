#include<stdio.h>
int main()
{
    int u=10,*ptr;
    ptr=&u;

    printf("Address of u = %0x",ptr);
    printf("Value of u = %d",u);

    printf("Address of u = %0x", &u);
    printf("Content of u = %d", *ptr);
    
    return 0;   
}

