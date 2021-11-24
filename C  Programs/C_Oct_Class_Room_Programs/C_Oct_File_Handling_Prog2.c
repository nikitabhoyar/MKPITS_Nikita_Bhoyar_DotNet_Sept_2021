
#include<stdio.h>
#include<string.h>

int main()
{
FILE *filepointer;
char dataToBeWritten[50] ="I am learning file operation in c";
filepointer = fopen("Test.text","w");

if(filepointer == NULL)
{
printf("Test.txt file failed to open");
}

else
{
printf("The file is now opened.\n ");
if(strlen(dataToBeWritten)>0)
{
fputs(dataToBeWritten.filepointer);
fputs("\n",filepointer);
}
fclose(filepointer);

printf("Data Succesfully wriiten in file Test.txt \n");
printf("The file is now closed");
}
return 0;
}  

