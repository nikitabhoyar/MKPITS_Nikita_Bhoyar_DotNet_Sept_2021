
#include<stdio.h>
int main()
{
   	int Number;
   	printf("Enter your choice of Month No : ");
   	scanf("%d",&Number);
   	switch(Number)
   	{
		case 1:
      			printf(" Your Current Month name is January");
      			break;
		case 2:
      			printf("  Your Current Month name is February");
      			break;
		case 3:
      			printf("  Your Current Month name is March");
      			break;
		case 4:
     			printf("  Your Current Month name is April");
      			break;
		case 5:
      			printf(" Your Current Month name is May");
      			break;
		case 6:
      			printf(" Your Current Month name is June");
      			break;
		case 7:
      			printf(" Your Current Month name is July");
      			break;
		case 8:
      			printf(" Your Current Month name is August");
      			break;
		case 9:
      			printf(" Your Current Month name is September");
      			break;
		case 10:
      			printf(" Your Current Month name is October");
      			break;
		case 11:
      			printf(" Your Current Month name is November");
      			break;
		case 12:
      			printf(" Your Current Month name is December");
      			break;
		default:
      			printf("Invalid Month number you entered \n");
      			break;
    	}
   return 0;
}

