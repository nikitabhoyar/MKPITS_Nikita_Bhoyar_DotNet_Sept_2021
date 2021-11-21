
#include<stdio.h>

int Factorial_Num(int);
void main()
{
  int num,factorial;
  printf("Enter a number to calculate its factorial \n");
  scanf("%d",&num);
  factorial = Factorial_Num(num);
  printf("Factorial of the num %d = %d \n",num,factorial);
}

 int Factorial_Num(int n)
 {
   int i,Fact=1;
   for(i=1;i<=n;i++)
   {
     Fact=Fact*i;
   }
   return Fact;
 }