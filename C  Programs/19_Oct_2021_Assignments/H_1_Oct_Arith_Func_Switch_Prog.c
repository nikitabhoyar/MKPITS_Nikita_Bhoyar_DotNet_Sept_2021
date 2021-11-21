
#include<stdio.h>
int Add(int,int);
int Sub(int,int);
int Mul(int,int);
int Div(int,int);
int main()
{
    int Num1, Num2, Ans;
    char operation;
    printf("\n Enter Your Choice of Character: ");
    operation = getchar();
    switch(operation)
    {
        case'a':
        case'A':
               
               Ans = Add(Num1,Num2);
               printf("\n %d + %d = %d ", Num1,Num2,Ans);
               break;

        case's':
        case'S':
               printf("Enter the value of Num1 and Num2 : ");
               scanf("%d %d", &Num1,&Num2);
               Ans = Sub(Num1,Num2);
               printf("\n %d - %d = %d ", Num1,Num2,Ans);
               break;

        case'm':
        case'M':
               printf("Enter the value of Num1 and Num2 : ");
               scanf("%d %d", &Num1,&Num2);
               Ans = Mul(Num1,Num2);
               printf("\n %d * %d = %d ", Num1,Num2,Ans);
               break;

        case'd':
        case'D':
               printf("Enter the value of Num1 and Num2 : ");
               scanf("%d %d", &Num1,&Num2);
               Ans = Add(Num1,Num2);
               printf("\n %d / %d = %d ", Num1,Num2,Ans);
               break;
    }

    return 0;
}


int Add(int a ,int b )
{
    return a+b;
}

int Sub(int a ,int b )
{
    return a-b;
}

int Mul(int a ,int b )
{
    return a*b;
}

int Div(int a ,int b )
{
    return a/b;
}

