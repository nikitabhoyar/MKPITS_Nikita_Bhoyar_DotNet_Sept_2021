

#include<stdio.h>
#define name "\n Nikita Bhoyar\n"
#define output printf
#define Square(x) x*x
#define Function(a,b,c) a*a+b*b+c*c
#include"defineheader.h"

/* macro in c Program*/
int main()
{

int n1=2,n2=3,n3=4;
printf(name);
output ("\n Square of 5 = %d ",Square(5));
printf("\n function (n1,n2,n3) = %d ", Function(n1,n2,n3));
printf("\n Power=%d",Power2(3));
return 0;

}

