

#include<stdio.h>
int main() 

{   
    int num; 
    printf("The numbers which is  divisible by 5 in the range of 1 to 100 are as : "); 

    for(num=1; num<=100; num++) 
    { 
       if(num%5==0) 
       { 
        printf("%d \n", num); 
       } 
    } 
    
    return 0;
 
} 


