#include<stdio.h>
int main()
{
    int v=5,*ptr;
    ptr=&v;

    printf("\n Address of v = %0x",ptr);
    printf("\n Value of variable v = %d",v);

    printf("\n content of v = %0x",&v);clear
    printf("\n content of v = %d",*ptr);

    return 0;

}
