#include<stdio.h>
int main()
{
    int celsius = 10,fahrenheit;
    while(celsius<=100)
    {
    fahrenheit =  celsius * 1.8 + 32 ;
    printf("\n %d deg celsius = %d fahrenheit", celsius, fahrenheit);
    celsius = celsius+5;
    }
    return 0;
}
