#include<stdio.h>

int outsource(int,int);
int main()
{

int x=10,y=20,z;
z=outsource(x,y);

printf("\n Addition = %d",z);
z=outsource(45,45);

printf("\n Addition = %d ",z);
x=67;
y=8;

printf("\n Addition = %d ", outsource(x,y));
printf("\n Addition = %d ", outsource(23,43));
return 0;

}
int outsource(int a ,int b )
{

int c;
c=a+b;
return c;

}

