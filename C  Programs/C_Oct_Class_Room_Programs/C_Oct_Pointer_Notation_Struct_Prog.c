.



#include<stdio.h>
typedef struct
{
char Name[30];
int age;
}
person;

int main()
{
person *people;
int n,i;
printf("\n How many people are there ");
scanf("%d",&n);
people = (person *)malloc(n*sizeof(person));

for(i=o;i<n;i++)
{
fflush(stdin);
printf("\n Enter name of person");
scanf("%d",&(people+i)->Name);
printf("\n Enter age of person");
scanf("%d",&(people+i)>age);
}

printf("\n List of people \n");
for(i=o;i<n;i++)
{
printf("\n %s  %d ",(people+i)->Name,(people+i)->age);
}

printf("\n size of person in memory = %d",sizeof(person));

}

