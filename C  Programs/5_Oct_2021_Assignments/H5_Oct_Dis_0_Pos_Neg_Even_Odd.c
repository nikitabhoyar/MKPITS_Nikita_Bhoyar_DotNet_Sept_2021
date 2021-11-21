
#include<stdio.h>
int main()
{
    int num;

    printf("Enter the number:");
    scanf("%d",&num);

    if(num > 0)
    printf(" %d = The number is Positive.\n",num);

    else if(num==0)
    printf(" %d = The number is Zero.\n",num);

    else if (num<0)
    printf(" %d =  The number is Negative\n",num);
       
    if(num%2 == 0)
    printf(" %d = The number is even\n",num);
   
    else if(num%2==1)
    printf(" %d = The number is Odd\n",num);

    return 0;
}

