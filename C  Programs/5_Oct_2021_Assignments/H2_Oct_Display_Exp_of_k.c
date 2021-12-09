
#include<stdio.h>
int main()
{
    int i,j,k;
    printf(" Enter the value of i and j = "); 
    scanf("%d%d", &i,&j);
    k=(--i)*2+2*(3*j+5);
    printf("\n The output of expression k is = %d", k);
    return 0;
}
