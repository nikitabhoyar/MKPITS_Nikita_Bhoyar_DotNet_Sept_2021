

#include<stdio.h>
int Max(int,int);
int Min(int,int);
void ShowMax_Min(int,int);
int main()
{
int x=10,y=100,a=123,b=564;
ShowMax_Min(x,y);
ShowMax_Min(a,y);
return 0;

}


int Max(int a, int b)
{
 if(a>b)
 return a;
 else 
 return b;
 }
 
 int Min(int a,int b)
 {
 if (a<b)
 return a;
 else
 return b;
 }
 
 void ShowMax_Min(int a,int b)
 {
 printf("\n Max no: is %d and Min no: is %d", Max(a,b), Min(a,b));
 }
 

