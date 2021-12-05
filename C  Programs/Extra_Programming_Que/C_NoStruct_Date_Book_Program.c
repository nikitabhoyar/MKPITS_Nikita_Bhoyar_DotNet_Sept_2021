
#include<stdio.h>
typedef struct 
{
    int day,month,year;

} date;

typedef struct 
{
    int id;
    char first_name[30];
    char last_name[30];
}   student;

student getstudent();  /*Function Declaration*/

student getstudent()    /*Function Defination*/
{
    student s ;
    printf("Enter student Id: ");
    scanf("%d",&s.id);
    fflush(stdin);  
    printf("Enter Firstname: ");
    gets(s.first_name);
    printf("Enter the last name: ");
    gets(s.last_name);
    
}


