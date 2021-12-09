
#include<stdio.h>

typedef union 
{
int size;
char Size[30];
}
shirt;


int main()
{
shirt Raymond;
printf("Enter size of shirt: ");
scanf("%d",&Raymond.size);

printf("\n Enter size of shirt: ");
scanf("%s",&Raymond.size);

printf("\n size of Raymond shirt is = %s , size of Raymond shirt is = %d ",Raymond.size,Raymond.Size);

}

