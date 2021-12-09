

#include <stdio.h>
int main()
{
    int  bin_num = 1100 ,deci_num = 0, base = 1, rem;
 
    printf("Enter the given binary number:");
    scanf("%d", &bin_num); 
    
    while (bin_num > 0)
    {
        rem = bin_num % 10;
        deci_num = deci_num + rem * base;
        bin_num = bin_num / 10 ;
        base = base * 2;
    }
    
    printf("Its decimal equivalent is = %d \n", deci_num);
    return 0;
}

