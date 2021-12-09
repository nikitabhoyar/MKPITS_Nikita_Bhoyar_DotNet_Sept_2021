
#include<stdio.h>
void ReverseArr (int*arr,int size );
int main()
{
    int arr[100],size,*left=arr,*right;

    printf("Enter the size of array:");
    scanf("%d",&size);

    right = &arr[size-1];

    printf("Enter elements in array:");
    while( left <= right)
    {   
        scanf("%d",left++);
    }

    printf("\n Array before reverse:");
    ReverseArr( arr,size );

    left = arr;

    while( left<right )
    {
        *left ^= *right;
        *right ^= *left;
        *left ^= *right;
    
    left++;
    right--;
    }

printf("\n Array after reverse:");
ReverseArr(arr,size);

return 0;

}

 void ReverseArr (int *arr,int size)
 {
     int *arrEnd = (arr+size-1);
     while(arr<=arrEnd)
     {
         printf("%d",*arr);
         arr++;
     }
 }
