
#include<stdio.h>
int main()
{
    char operator;
    int num1,num2;

    printf("Enter an operator in this (+ , _ , * , /): ");
    scanf("%c", &operator);

    printf("Enter two operands:  ");
    scanf("%d %d" , &num1 , &num2);

    switch(operator)
    {
       case '+':
       printf("%d + %d = %d" ,num1,num2, num1+num2);
       break ;

       case '-':
       printf("%d - %d = %d", num1,num2, num1 - num2);
       break;

       case'*':
       printf("%d * %d = %d" , num1 ,num2 , num1 * num2);
       break;

       
       case'/':
       printf("%d / %d = %d" , num1 ,num2 , num1/num2);
       break;


       deafault:
       printf("Error!Operator is not correct");
    }

    return 0;

}

