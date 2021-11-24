

#include<stdio.h>
int main()
{
    int i=0,radius;
    int pie=3.14;
    float area_of_circle;
    
        printf("\n Enter the Radius:");
        scanf("%d",&radius);
        area_of_circle = pie*radius*radius;
        printf("The area of circle is= %0.3f", area_of_circle);
    

    return 0;
}

