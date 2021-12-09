
#include<stdio.h>
int main()
{
    int i,size,a[10],Even_Count=0,Odd_Count=0;
    printf("\n Please Enter the Size of an array:  ");
    scanf("%d",&size);
    
    printf("\n Please Enter the Array element:  ");
    for(i=0;i<size;i++)
    {
        scanf("%d",&a[i]);
    }

    for(i=0;i<size;i++)
    {
        if(a[i]%2==0)
        {
            Even_Count++;
        }
        else
        {
            Odd_Count++;
        }
    }
    printf("\n The total Even Numbers are = %d ",Even_Count);
    printf("\n The total Odd Numbers are = %d ", Odd_Count);

    return 0;

}