
#include<stdio.h>
int main()
{
  
  int gm,kg;
  
  printf(" Enter the weight in gram:");
  scanf("%d",&gm);
  
  kg=gm/1000;
  gm=gm%1000;
  
  printf("\n The value %d kg %d gram",kg,gm);
  return 0;
  
}


