

#include<stdio.h>

int main()
{
static int x=5;
if(x>=1)
{
printf("\n x=%d",x);
x--;
main();
}

return 0;

}

