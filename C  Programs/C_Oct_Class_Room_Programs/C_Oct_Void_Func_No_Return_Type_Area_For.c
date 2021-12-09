

#include<stdio.h>

void Area_Circle(int);
int main()
{
int n,i,radius;
printf("\n How many time you want to find the area of circle ?");
scanf("%d",&n);
for(i=0;i<n;i++)
{

 printf("\n Enter radius of circle");
 scanf("%d",&radius);
 
 Area_Circle(radius);
}
 return 0;
 
 }
 
 void Area_Circle(int r)
 {
 float A=3.14*r*r;
 printf("\n Area of Circle = %2.f",A);
 }

