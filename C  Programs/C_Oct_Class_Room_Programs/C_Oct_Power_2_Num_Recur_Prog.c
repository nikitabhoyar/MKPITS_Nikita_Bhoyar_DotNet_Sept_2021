

#include<stdio.h>
int PowerTwo(int);
int SumNum(int);
int main()
{

int n=5,N;
N=SumNum(n);
printf("\n %d the sum of N number= %d ", n , N);

return 0;
}

int PowerTwo(int n)
{
if(n==1)
return 2;
else
return 2* PowerTwo(n-1);
}

int SumNum(int n )
{
if(n==1)
return 1;
else
return n+SumN(n-1)
}


