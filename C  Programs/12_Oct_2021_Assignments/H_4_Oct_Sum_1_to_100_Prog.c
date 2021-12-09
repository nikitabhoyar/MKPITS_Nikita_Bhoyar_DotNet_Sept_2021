#include<stdio.h>
int Sum_1_100();
int main()
{
  int Total;
  Total=Sum_1_100();
  printf("\n The Sum of 1 to 100 numbers are = %d",Total);
   
}

int Sum_1_100()
{
  int i,sum=0;
  for(i=1;i<=100;i++)
  {  
    printf(" %d \n", i );
    sum+=i;
  }
  return sum;
}