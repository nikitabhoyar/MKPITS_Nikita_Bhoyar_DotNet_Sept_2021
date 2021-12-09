
#include<stdio.h>
typedef struct
{
int day,month,year;
}
Date;

typedef struct 
{
int rollno;
char name[30];
int std;

}student;

int main()
{
   Date admitdate={25,7,2021};
   student s1={18,"Nikita",17};
   printf("\n The student Admission date is %d-%d-%d",admitdate.day,admitdate.month,admitdate.year);
   printf("\n and the student details are as follows \nRoll no:%d\nName:%s\nStandard:%d",s1.rollno,s1.name,s1.std);
} 


