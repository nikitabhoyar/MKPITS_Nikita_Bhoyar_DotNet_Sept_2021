


#include<stdio.h>
typedef union 
{
int size;
char Size[30];
char color[30];
}
Shirt;

int main()
{
Shirt Raymond;
printf("\n Enter size of shirt: ");
scanf("%d",&Raymond.size);

printf("\n Enter size of shirt: ");
fflush(stdin);
gets(Raymond.Size);
printf("\n Enter color of shirt: %s",&Raymond.color);
fflush(stdin);
gets(Raymond.color);

printf("\n Size of Raymond Shirt is = %s,\n size of Raymond shirt is = %d ,\n Color of shirt is %s ",Raymond.Size,Raymond.size,Raymond.color);

}

