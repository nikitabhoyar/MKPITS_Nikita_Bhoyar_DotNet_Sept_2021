


#include<stdio.h>
#include<conio.h>


typedef struct
{
int day,month,year;
}
date;

typedef struct
{
int empid;
char empname[20];
date doj;
}
emp;

int main()
{
emp e1={1,"Nikita Bhoyar",17,9,1999};
printf("Employee details are: \n");
printf("Employee ID: %d \n",e1.empid);
puts(e1.empname);
printf("Date of joining is %d /%d /%d ",e1.doj.day,e1.doj.month,e1.doj.year);

}

