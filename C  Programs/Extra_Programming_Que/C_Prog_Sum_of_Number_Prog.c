

#include<stdio.h>
int main()
{
    int num,sum=0;
    printf("The first 100 numbers are:\n");

    for(num=1; num<= 100 ; num++)
    {
        sum = sum+num;
        printf(" %d \n",num);

    }

    printf("\n The sum is:%d   \n ",sum);
    return 0;
}