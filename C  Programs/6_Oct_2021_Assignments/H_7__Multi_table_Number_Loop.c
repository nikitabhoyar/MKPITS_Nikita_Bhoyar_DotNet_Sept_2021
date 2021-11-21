#include <stdio.h>
void main()
{
   int j,Mul_Num;
   printf("Input the number: ");
   scanf("%d",&Mul_Num);
   printf("\n");
   for(j=1;j<=10;j++)
   {
     printf("%d X %d = %d \n",Mul_Num,j,Mul_Num*j);
   }
} 