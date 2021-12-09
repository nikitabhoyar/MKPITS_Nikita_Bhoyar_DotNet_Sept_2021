
#include<stdio.h>
#include<string.h>

struct student
{
    char name[20] , cityname[20];
    int rollno , age , id ;
    
}student1 ;

int main()
{
    strcpy(student1.name ,"Prachi Bhoyar");
    student1.rollno = 18;
    student1.age=21;
    student1.id= 1;
    strcpy(student1.cityname,"Mumbai");

    printf("Student Details Information:\n");
    printf("Name:%s \n", student1.name);
    printf("Roll no:%d \n", student1.rollno);
    printf("Id:%d \n", student1.id);
    printf("Cityname:%s\n", student1.cityname);
    return 0;

}
