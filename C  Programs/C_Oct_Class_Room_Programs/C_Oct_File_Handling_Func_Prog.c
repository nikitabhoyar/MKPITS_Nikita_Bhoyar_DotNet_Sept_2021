
#include<stdio.h>
#include<string.h>
typedef struct 
{
char studname[30];
int  Rollno,Marks;
}
student;
 
void display(student *);

main()
{
student s[3],s2;
int i;
char n[30];
for(i=0;i<0;i++)
{
printf("Enter the Roll no: ");
scanf("%d",&s[i].Rollno);
fflush(stdin);

printf("Enter Marks: ");
scanf("%d",&s[i].Marks);

printf("Enter student name: ");
fflush(stdin);
gets(s[i].studname);
}

display(s);
}

void display(student *s)
{
int i;
FILE *outfile;
outfile=fopen("student.dat","w");

for(i=0;i<3;i++)
{
printf("\n Student details are \n : ");
printf("\n Roll no is %d \n",(s+i)->Rollno);

puts((s+i)->studname));

if((s+i)->Marks>=40 && (s+i)->Marks<100))
{
printf("\nResult=pass");
}
else
{
printf("\nResult=fail");
}
fwrite(&s[i],sizeof(student),1,outfile);
}
}

