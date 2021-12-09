


#include<stdio.h>
#include<malloc.h>
void DisplayArray(int *,int n);
int main()
{
 
 int *number,n,i;
 printf("Enter the size of Array");
 scanf("%d",&n);
 number=(int *)malloc(n*sizeof(int));
 printf("\n Enter %d numbers",n);
 
 for(i=0;i<n;i++)
 {
  scanf("%d",(number+i));
 }
 
  DisplayArray(number,n);
  return 0;
  
}

void DisplayArray(int *A,int n )
{
int i;
for(i=0;i<n;i++)
printf("%5d",*(A+i));

}

