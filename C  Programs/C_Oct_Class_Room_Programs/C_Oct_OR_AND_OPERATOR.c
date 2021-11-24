

#include<stdio.h>
int main()
{
int i, sum=0;

    printf("Number divisible by 3 and 7 are :");
    for(i=1;i<=100;i++)
    {
        if((i%3==0) && (i%7==0))
        {
            printf("%4d",i);
            sum+=i;
        }
    }
    
    printf("\nThe sum of numbers divisible by  3 and 7 are %d",sum);  
    return 0;
    
} 
   


