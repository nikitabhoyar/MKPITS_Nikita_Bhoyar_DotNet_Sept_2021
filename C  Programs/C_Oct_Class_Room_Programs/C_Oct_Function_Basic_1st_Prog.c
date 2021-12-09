#include<stdio.h>

int outsource(int,int); // step 1)Declaration of prototype //
int main()
{

int x=10,y=20,z;
z=outsource(x,y);

printf("\n Addition = %d",z);
z=outsource(45,45);

printf("\n Addition = %d",z);

int outsource(int a ,int b ) 
{

int c;
c=a+b;
return c;

}
return 0;
}

