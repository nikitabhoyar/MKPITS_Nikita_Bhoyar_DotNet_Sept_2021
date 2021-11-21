



#include<stdio.h>
#include<conio.h>
#include<math.h>

int main()
{
  int sec;
  int hr;
  int min;
  int ss;

  printf("Enter time in second:");
  scanf("%d",&sec);

  hr  = sec/3600;
  min = (sec-hr*3600)/60;
  ss  = sec-hr*3600-min*60;

  printf("%d seconds = %d hours:%d minutes:%d seconds",sec,hr,min,ss);
  getch();
  return 0;


}


