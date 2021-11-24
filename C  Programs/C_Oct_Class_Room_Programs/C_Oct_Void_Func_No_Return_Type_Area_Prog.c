

#include<stdio.h>

void Area_Circle(int);
int main()
{
int radius;
printf("\n Enter the radius of circle");
scanf("%d",&radius);

 Area_Circle(radius);
 
 return 0;
 
 }
 
 void Area_Circle(int r)
 {
 float A=3.14*r*r;
 printf("\n Area of Circle = %2.f",A);
 }

