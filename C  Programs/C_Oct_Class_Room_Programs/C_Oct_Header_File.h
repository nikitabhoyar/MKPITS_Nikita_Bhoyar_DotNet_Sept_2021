
#include<stdio.h>
#define line "\n..............\n"
#define output printf
#define Square(x) x*x
#define Function(a,b,c) a*a+b*b+c*c
#define pie 3.14 
int power(int n)
if(n<=1)
{
return 2;
else
return 2*power2(n-1);
}

