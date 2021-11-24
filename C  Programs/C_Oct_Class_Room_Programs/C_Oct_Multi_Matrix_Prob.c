

#include<stdio.h>
int main()
{

int i,j,k,m,n,p,q,a[10][10],b[10][10],c[10][10];
printf("Enter the dimension of first matrix");
scanf("%d%d",&n,&m);

printf("Enter the dimension of second matrix");
scanf("%d%d",&p,&q);

if(n==p)
printf("Matrix Multiplication is possible");
printf("Enter elements of first matrix");

for(i=0;i<m;i++)
{
for(j=0;i<n;j++)
{
scanf("%d",&a[i][j]);
}
}


printf("Enter the elements of second matrix");

for(i=0;i<p;i++)
{
for(j=0;i<q;j++)
{
scanf("%d",&b[i][j]);
}
}

/*Multiplication Matrix*/

for(i=0;i<m;i++)
{
for(j=0;i<n;j++)
{
c[i][j]=0;

for(k=0;k<n;k++)
{
c[i][j]+= a[i][k]*b[k][j];

}
}
}

printf("Multiplication matrix is as follows");

for(i=0;i<m;i++)
{
for(j=0;i<n;j++)
{
printf("%2d",c[i][j]);
}

printf("\n");

}

return 0;

}

