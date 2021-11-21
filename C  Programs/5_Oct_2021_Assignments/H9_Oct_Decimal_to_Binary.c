
#include<stdio.h>
int main()
{
    int dec_number = 65,c,k;
    printf(" The binary number system of given decimal number is: ",dec_number);

    for(c=10;c>=0;c--)
    {
        k=dec_number>>c;
        if(k & 1)
        printf("1");
        else
        printf("0");

    }
    printf("\n");
    return 0;
}



