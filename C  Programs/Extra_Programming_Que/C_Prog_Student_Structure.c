
#include<stdio.h>
typedef struct
{
   int day,month,year;  
}Date;

typedef struct
{
   int id,Eng,Math,Sci;
   char first_name[40];
   char last_name[70];
}student;

student getstudentdata();  /*Function Declaration*/

void showstudentdata(student); /*Function Declaration*/

main()
{
    student me;
    me=getstudentdata();
    showstudentdata(me);

}

student getstudentdata() /*Function Defination*/
{

student s;
printf("Enter Student id: ");
scanf("%d",&s.id);
fflush(stdin);

printf("Enter the First Name: ");
gets(s.first_name);
fflush(stdin);

printf("Enter the last Name: ");
fflush(stdin);
gets(s.last_name);

return s;
}

void showstudentdata(student s)
{
    float avg;
    printf("\n Student Details: ");
    printf("\n ID %d",s.id);
    printf("\n First Name: %s",s.first_name);
    printf("\n Last Name: %s",s.last_name);
    avg=(s.Eng+s.Math+s.Sci)/3.0;
    if(avg<40)

    printf("\n Result: FAIL");
    else
    printf("\n Result: PASS");


}
