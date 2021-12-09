
#include<stdio.h>

struct Distance
{
    int feet;
    float inch;
    
} ;

int main()
{
    struct Distance d1,d2;
    d1.feet = 10;
    d2.inch = 45;

    printf("Information about feet and inch\n");
    printf("Feet:%d\n",d1.feet);
    printf("Inch:%d",d1.inch);
    return 0;
}

