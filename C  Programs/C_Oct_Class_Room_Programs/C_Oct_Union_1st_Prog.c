


#include<stdio.h>

union stud
{
float avg;
int id;
};

int main()
{
union stud s;
printf("Enter avg marks:  ");
scanf("%f",&s.avg);
printf("Enter id:  ");
scanf("%d",&s.id);
printf("\n Avg is %0.2f",s.avg);
printf("\n Id is %d",s.id);

return 0;
}

