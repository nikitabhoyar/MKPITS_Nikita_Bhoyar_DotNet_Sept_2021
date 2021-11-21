

#include<stdio.h>
int main()
{
    int num;
    printf("Enter the number:", num);
    scanf("%d",num);
    printf("Number\tSquare\tCube\n");
    while(num<=10);
    {
      printf("%d\t%d\t%d\n", num, num*num, num*num*num);
      num++;
    }
    return 0;
}
