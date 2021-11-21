/* The program is based on logical OR and Logical AND Operator.
1)The explanation of the expression is first value of a is 0 and then a has postfix decrement operator in the d expression and  the value of operand a is alter after it is used before  the value of a is 1 in the c expression that's why the output of value a is 0.
2)The same thing is happen with operand b also. b has pre decremnet operator means the value of operand alter before it is used.
3)In c expression the value of a is 1 after performaning OR operation we get the value of exp c is 1 i.e c= a=1+--b(0) = 1.  
4)In expression d the logical And  operation is performed and a has posftfix decrement opertor and b has pre decrement operator and In And we have to multiply the values of both operand . so by mutiplying the values of both operand we get the value of expression d is 0*/



#include<stdio.h>
int main()
{
    int a= 1;
    int b= 1;
    int c= a||--b;
    int d= a-- && --b;
    printf(" The output of given problem is a = %d, b = %d, c = %d , d = %d ", a , b, c , d);

}
