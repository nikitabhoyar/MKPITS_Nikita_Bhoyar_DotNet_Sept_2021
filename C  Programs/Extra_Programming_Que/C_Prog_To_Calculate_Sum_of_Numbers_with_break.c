
//The program is to calculate the sum of numbers(10 numbers Max)//

//If the user enters a negative number, then loop terminates//

#include<stdio.h>
int main()
{
    int i,number,sum=0;
    for(i=1; i<=10 ; i++)
    {
       printf("Enter n%d: ", i);
       scanf("%d",&number);  

//If the user enters a negative numbers , break statement break  the loop//

    if(number<0)
    {
     break;
    }
    sum+=number;
}

printf("Sum = %d" , sum);

return 0;

}





