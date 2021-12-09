
#include<stdio.h>
struct Date
{
int day,month,year;
};

int main()
{

struct Date today bday={17,9,1999};
int x=10; 

printf("\n Enter todays's date in DD/MM/YYYY Format:");
scanf("%d/%d/%d",&today.day,&today.month,&today.year);

printf("\n Today is %d %d %d ",today.day,today.month,today.year);

printf("\n Birthday is %d %d %d ",bday.day,bday.month,bday.year);

}

