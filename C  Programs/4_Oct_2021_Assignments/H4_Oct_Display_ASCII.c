
#include<stdio.h>
int main()

{
    int  i;
    char c;
    for(i=1; i<=10 ; i++)
    {
        printf("\n Enter the character: ");
        scanf("%c",&c);
        printf("The ASCII value of the character is %c = %d ", c , c);
    }

    return 0;

}




