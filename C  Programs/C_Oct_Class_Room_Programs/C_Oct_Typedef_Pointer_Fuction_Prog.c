


#include<stdio.h>
typedef struct 
{
int id;
char name[20];
float sal;
}
Emp;
void display(Emp*);
int main()
{
Emp e[3];
int i;
float s=35000;

for(i=0;i<3;i++)
{
printf("\n Enter ID: ");
scanf("%d",&e[i].id);
printf("\n Enter name: ");
fflush(stdin);
gets(e[i].name);
printf("Enter sal: ");
scanf("%f",&s); 

e[i].sal=s;
}

display(e);

return 0;

}

void display(Emp *e)
{
int i;
for(i=0;i<3;i++)
printf("\n Id is %d \t name %s\t salary Rs.%8.2f",(e+i)->id,(e+i)->name,(e+i)->sal);
}


