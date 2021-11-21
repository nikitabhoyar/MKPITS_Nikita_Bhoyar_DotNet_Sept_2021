#include<stdio.h>
#define SIZE 10
int main()
{
  int marks [SIZE]  ;
  int index,sum,avg;

  printf("Enter the marks of %d students: \n",SIZE);

  for(index=0;index<SIZE;index++)
  {
      scanf("%d",&marks[index]);
  }
  sum=0;
  for(index=0;index<SIZE;index++)
  {
      sum=sum + marks[index];      
  }
  avg=sum/SIZE;
  printf("Average marks=%d",avg);
  return 0;

}