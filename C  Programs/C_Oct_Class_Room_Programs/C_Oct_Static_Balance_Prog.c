


#include<stdio.h>

static int bal=1000;


int main()
{
int amount,Balance;

printf("\n Enter the amount to be deposited: ");
scanf("%d",&amount);

Balance=deposit(amount);
printf("\n Account Balance = %d",Balance);

printf(" \n Enter the amount to be deposited: ");
scanf("%d",&amount);

Balance=deposit(amount);
printf("\n Account Balance = %d",Balance);

return 0;

}

int depsosit(int amt)
{
return bal+= amt;
}

int withdrawal(int amt)
{
return bal-=amt;
}


