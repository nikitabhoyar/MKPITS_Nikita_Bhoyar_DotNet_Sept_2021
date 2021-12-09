
#include<stdio.h>
#include<math.h>

int main()
{
 float Prin_amount, Annual_rate, Rate_per_month, EMI;
 int Num_month;

 printf("Enter principal amount: ");
 scanf("%f", &Prin_amount);
 printf("Enter annual interest rate: ");
 scanf("%f", &Annual_rate);
 printf("Enter number of months: ");
 scanf("%d", &Num_month);

 /* Calculation of Interest Rate Per Month */
 Rate_per_month = Annual_rate/(12*100);

 /* Calculation of Monthly intsallment (EMI) */
 EMI = Prin_amount * Rate_per_month * pow(1+Rate_per_month,Num_month)/(pow(1+Rate_per_month,Num_month)-1);

 printf("Monthly EMI: %f", EMI);

 return 0;
}

