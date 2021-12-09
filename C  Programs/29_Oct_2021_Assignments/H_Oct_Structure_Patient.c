
#include<stdio.h>

typedef struct
{
    int date, month , year;
} date;

typedef struct 
{
    char Firstname[10] ,Lastname[20] ,DoctorName[10];
    long Pateintage, PateintId;
    date Appointmentdate;
} pateint;

int main()
{
    pateint p1;
    printf("The pateint details are as follows: \n");
    printf("Enter pateint Firstname: ");
    scanf("%s",p1.Firstname);

    printf("Enter pateint Lastname: ");
    scanf("%s",p1.Lastname);

    printf("Enter pateintId: ");
    scanf("%lf",p1.PateintId);

    printf("Enter pateintage: ");
    scanf("%lf",p1.Pateintage);

    printf("Enter Appointmentdate in dd/mm/yyyy: ");
    scanf("%d/%d/%d",&p1.Appointmentdate.date,&p1.Appointmentdate.month,&p1.Appointmentdate.year);

    printf("Enter Doctorname: ");
    scanf("%s",p1.DoctorName);
    return 0;
}