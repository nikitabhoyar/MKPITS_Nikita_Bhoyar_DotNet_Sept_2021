#include<stdio.h>
int main()
{
int num1,num2,gcd;
Input:printf("Enter two numbers :");
scanf("%d %d",&num1,&num2);

for(gcd=num1>num2?num2:num1;gcd<=(num1>num2?num2:num1);gcd--)
goto End;

{   
if(num1%gcd==0&&num2%gcd==0);
goto Input;
}

End:printf(" The GCD of two number is %d",gcd);
return 0;

}
