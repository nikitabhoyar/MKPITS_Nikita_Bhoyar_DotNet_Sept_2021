
#include<stdio.h>
typedef struct 
{
int day,month,year;
}date;

typedef struct 
{
int Eng,Math,Sci;
char first_name[30];
char last_name[30];
}student; 


student getstudent();  /*declaration of function*/
void showstudent(student);

main()
{
student me;
me=getstudent();
showstudent(me);
}

student getstudent() /*function defination*/
{
student s;
printf("Enter student Id: ");
scanf("%d",&s.id);
fflush(stdin);
printf("Enter Firstname : ");
gets(s.first_name);
printf("Enter Lastname : ");
fflush(stdin);
gets(s.Last_name);
printf("Enter the subject marks of English Science Maths: ");
scanf("\n%d\n%d\n%d",&s.Eng,&s.Math,&s.Sci);
return s;
}

void showstudent(student s)
{
float avg;
printf("\nStudent Details: ");

printf("\n id: %d",s.id);
printf("\n First Name is: %s",s.first_name);
printf("\n Last Name is : %s",s.last_name);
avg=(s.Eng+s.Math+s.Sci)/3.0;

if(avg<40)
{
printf("\n The Result is fail");
else
printf("\n The Result is passed");

}

