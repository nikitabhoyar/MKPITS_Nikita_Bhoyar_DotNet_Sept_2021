#include<stdio.h>
int main()
{
    int arr[20],Num,i;
    int Sum_Even,Sum_Odd,Count_Even=0,Count_Odd=0;

    printf("\n Enter the size of the number array: ");
    scanf("%d",&Num);

    printf("\n Enter the elements of the array:\n"); 

    for(i=0;i<Num;i++)
    {
        scanf("%d",&arr[i]);
    }

    for(i=0;i<Num;i++)
    {
        if(arr[i]%2==0)
        {
            Sum_Even+=arr[i];
            Count_Even++;
        }
        else
        {
            Sum_Odd+=arr[i];
            Count_Odd++;
        }
    }

    printf("\n The sum of Even Numbers is = %d \n" , Sum_Even);

    printf("\n The Total Count of Even Numbers is = %d \n" , Count_Even);

    printf("\n The sum of Odd Numbers is = %d \n" , Sum_Odd);
    
    printf("\n The Total Count of Odd  Numbers is = %d \n" , Count_Odd);
    
    return 0;
 
}

