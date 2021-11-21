
#include<stdio.h>
int Sum_1_100();
int main()
{
  int Total;
  Total=Sum_1_100();
  printf("\n The Sum of 1 to N numbers are = %d",Total);
   
}

int Sum_1_100()
{
  int i,num,sum=0;
  printf("Enter the range of number element: ");
  scanf("%d",&num);
  for(i=1;i<=num;i++)
  {  
    printf(" %d \n",i);
    sum+=i;
  }
  return sum;
}