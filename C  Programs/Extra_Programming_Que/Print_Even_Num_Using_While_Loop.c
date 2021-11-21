#include<stdio.h>
#include<conio.h>

void main()
{
    int number,last;
    clrscr();
    printf("Enter the last number:  \n");
    scanf("%d",&last);

    //while loop//
    //code for even number list//

    printf("Even Number list:  \n");
    scanf("%d",&last); 

    n=2;
    while(n<=last)
    {
        printf("%d",n);
        n=n+2;
    }

    //code for odd number list//   
    printf("Even number list:  \n")
    n=1;
    while(n<=last)
    {
        printf("%d",n);
        n=n+2;
    }
    
    getch();
}
    


