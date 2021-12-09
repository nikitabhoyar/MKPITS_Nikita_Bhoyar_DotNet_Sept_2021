


#include<stdio.h>
int main()
{

char str[45],ans;
printf("Enter a character y");
ans=getchar();
printf("\n.........\n");
putchar(ans);
fflush(stdin);

printf("Enter a string");
gets(str);
/*scanning the whole string including the white spaces*/
printf("%s",str);
puts(str);
return 0;

}

