#include<stdio.h>
#include<malloc.h>
int main()
{
float *price,amount=0,Total_bill=0;
int *qty,i,n;

printf("\n How many items you want to purchase?");
scanf("%d",&n);

price=(float*)malloc(n*sizeof(float));/*Single sell price has been expanded to block of memory of size n)*/

qty=(int *)malloc(n*sizeof(int));

for(i=0;i<n;i++)
{
printf("\n Please enter price: ");
scanf("%f",(price+i));
printf("\n How much quantity is purchased: ");
scanf("%d",(qty+i));
amount+= *(price+i)*(*(qty+i));
Total_bill+=amount;
}

printf("\n Total bill of number of item is Rs.%4.2f ", Total_bill);
return 0;

}
