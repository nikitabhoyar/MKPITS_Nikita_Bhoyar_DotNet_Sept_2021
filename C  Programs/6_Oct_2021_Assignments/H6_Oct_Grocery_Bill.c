

#include<stdio.h>
int main()
{
    int i,Item,Quantity;
    float Price, Amount, Total_Bill=0.0;
    printf("Enter the number of Items you want to purchase:");
    scanf("%d",&Item);

    for(i=0;i<Item;i++)
    {
      printf("\n Enter the Price of Item:");
      scanf("%f",&Price);
      printf("\n Enter the Quantity of Item :");
      scanf("%d",&Quantity);
      Amount = Price*Quantity;
    }
	
	printf("\n Item no Price Quantity Amount\n ");
	
	for(i=0;i<Item,i++)
	j=i+1;
	{
	  printf("\n %d %3f %d %2f ",Item,Price,Quantity,Amount ); 
	  Total_Bill+=Amount;
	}
	
	printf("\n Total Bill of number of Item are = Rs./ %4.2f",Total_Bill);
	
     }
  
    return 0;

}

