#include<stdio.h>
void Dollar_Rupee(float);
int main()
{ 
  float dollars;
  printf("Enter the dollars:");
  scanf("%f",&dollars);
  Dollar_Rupee(dollars);
}

void Dollar_Rupee(float dollars)
{
    int rupees = dollars*70;
    printf("\n Your Converted Dollar into Rupees is %d ", rupees);
}