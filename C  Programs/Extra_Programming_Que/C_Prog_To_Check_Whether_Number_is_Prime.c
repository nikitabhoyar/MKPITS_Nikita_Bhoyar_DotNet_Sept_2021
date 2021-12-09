
#include<stdio.h>
int  main()
{
    int number,i,flag=0;
    printf("Enter a positive integer: ");
    scanf("%d", &number);

    for(i=2;i<=number/2;i++)
    {
        if(number%i==0)
        {
            flag = 1;
            break;
        }
        if(number==1)
        {
            printf("1 is neither prime nor composite");
        }
        else
        {
            if(flag==0)
            printf("%d is a prime number " , number);
            else
            printf("%d is not a prime number " , number);

        }
        return 0;

    }
}