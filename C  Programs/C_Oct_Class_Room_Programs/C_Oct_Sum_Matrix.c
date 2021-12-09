



   #include<stdio.h>
   int main()
   {
     int i,j,a[3][3],sum,A=0;
     printf("\n Enter 9 elements");

     for(i=0;i<3;i++)
      {
       for(j=0;j<3;j++)
       {
       scanf("%d",&a[i][j]);
       }
    }
     
	printf("\n Given matrix of row sum is as follows \n");
	
	for(i=0;i<3;i++)
     {
	sum=0;
     for(j=0;j<3;j++)
       {
        printf("%3d",a[i][j]);
	   sum+=a[i][j];
        }
	 printf("\n sum = %d \n",sum);
	 A+=sum;
	 }
	  
	  
     printf("Total sum of all elements of matrix is = %d \n",A);
	
     return 0;
	
	}

