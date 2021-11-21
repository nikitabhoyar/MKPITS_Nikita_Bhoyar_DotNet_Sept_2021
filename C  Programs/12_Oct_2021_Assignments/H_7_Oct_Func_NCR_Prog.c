#include<stdio.h>
int Comb_Num(int);
int main()
{
 int n,r,ncr;
 printf("Enter the number");
 scanf("%d",&n);
 printf("Enter the number");
 scanf("%d",&r);
 ncr = Comb_Num(n)/(Comb_Num(r)*Comb_Num(n-r));
 printf("Value of %dC%d = %d \n",n,r,ncr);
return 0;

}

int Comb_Num(int n)
{
    int i,f=1;
    for(i=1;i<=n;i++)
    {
        f=f*i;
    }
    return f;

}