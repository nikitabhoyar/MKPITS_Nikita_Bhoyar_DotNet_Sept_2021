

#include<stdio.h>
int main()
{
    int arr[20],Num,i;

    printf("\n Enter the size of the number array: ");
    scanf("%d", &Num);

   

    for(i=0;i<Num;i++)
    {
        if(arr[i]%2==0)
        {
            arr[i] = 0 ;
            
        }
        else
        {
            arr[i]= 1;   
        }
    }

    for(i=0;i<Num;i++)
    {
    printf("\n %d",arr[i]);
    }
     
    return 0;
 
}

