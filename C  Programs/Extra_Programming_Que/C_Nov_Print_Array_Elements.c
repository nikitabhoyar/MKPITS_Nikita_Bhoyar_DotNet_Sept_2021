#include<stdio.h>
#define MAX_SIZE 1000
int main()

{
    int arr[MAX_SIZE],i,N;
    
    printf("Enter the size of Array:");
    scanf("%d",N);

    printf("Enter the %d element in the array:",N);
    for(i=0;i<N;i++)
    {
        scanf("%d",&arr[i]);
    }

    printf("\n Elements in array are :");
    for(i=0;i<N;i++)
    {
        printf("%d, ", arr[i]);
    }
    return 0;

}