


#include<stdio.h>
void Swap(int *,int *);
int main()
{

int x=100,y=200;
printf("\n Before swap x=%d and y=%d", x,y);

Swap(&x,&y);

printf("\n After swap x=%d and y=%d",x,y);

}

void Swap(int *ptr1,int *ptr2)
{
int temp;

temp=*ptr1;
*ptr1 = *ptr2;
*ptr2 = temp;
}

