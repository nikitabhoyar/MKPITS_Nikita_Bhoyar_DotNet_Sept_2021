
#include<stdio.h>
#include<string.h>

 //struct with typedef person//

typedef struct person
{
    char name[50];
    int cityno;
    float salary;
} person;

int main()
{
    person p1;
    strcpy(p1.name,"Nikita Bhoyar");
    p1.cityno = 1984;
    p1.salary = 2500 ;
    
    printf("Name:%s \n"  , p1.name);
    printf("CityNo:%d\n" , p1.cityno);
    printf("Salary:%d\n " , p1.salary);
    return 0;

}