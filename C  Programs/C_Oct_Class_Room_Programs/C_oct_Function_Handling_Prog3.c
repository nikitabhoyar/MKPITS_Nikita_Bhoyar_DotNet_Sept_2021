
#include<stdio.h>
#include<string.h>

int main()
{
FILE*filepointer;

char dataToBeRead[50];
filepointer = fopen("Test.txt" ,"r");

if(filepointer == NULL)
{
printf("Test.txt file failed to open");
}
else
{
printf("The file is now opened\n");

while(fgets (dataToBeRead,50,filepointer)!=NULL)
{
printf("%s",dataToBeRead);
}

printf("Data successfully read from file Test.c \n");
printf("The file is now closed.");
}
return 0;
}

