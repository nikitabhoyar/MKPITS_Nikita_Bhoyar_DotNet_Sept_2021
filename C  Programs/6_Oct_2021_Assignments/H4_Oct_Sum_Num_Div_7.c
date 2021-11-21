#include<stdio.h>
int main() 

{   
    int num, sum=0 , count=0 ;
    
    for(num = 1 ; num<100; num++) 
   { 
    if(num%7==0) 
   { 
    sum = sum + num;
    count++;
   } 
   }

    printf(" Total numbers which is divisble between 1 to 100 is: %d \n",+count);
    printf(" The sum of number which is divisible by 7 is: %d ", +sum );

   return 0;
} 





