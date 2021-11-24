


#include<stdio.h>
void function();
float pi=3.14;    //global varaible//
int r=1000;

int main()
{
auto int x=10;
auto int y=200;
printf("\n main x=%d pi=%.2f r=%d" ,x,pi,r);
function();
return 0;
}

void function()
{
auto int x=100;
extern int r;
r+=500;
printf("\n x=%d pi=%.2f r=%d",x,pi,r);
}

