


#include<stdio.h>

typedef struct
{
int day,month,year;
}
date;

typedef struct
{
char  mediname[20];
float mediprice;
date  mfdate,expdate;
}
Medicine;

int main()
{
Medicine m1;

printf("Medicine  details are: \n");
printf("Medicine  Name: ");
scanf("%s",m1.mediname);

printf("Enter the Medicine price: ");
scanf("%f",&m1.mediprice);

printf("Enter the Manufacture date of Medicine in format dd/mm/yyyy: ");
scanf("%d/%d/%d",&m1.mfdate.day,&m1.mfdate.month,&m1.mfdate.year);

printf("Enter the Expiry date of Medicine in format dd/mm/yyyy: ");
scanf("%d/%d/%d",&m1.expdate.day,&m1.expdate.month,&m1.expdate.year);



}



